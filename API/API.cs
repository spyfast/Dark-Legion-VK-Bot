using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using DarkLegion.RuCaptcha;

namespace DarkLegion.API
{
    public class API
    {
        private string username { get; set; }
        private string password { get; set; }
        private string Token { get; set; }

        private WebClient webClient = new WebClient();

        private Random random = new Random();


        public string FirstName;
        public API(string username, string password)
        {
            this.username = username;
            this.password = password;
        }        
        public string LogIn()
        {
            dynamic toJson = null;
            try
            {
                
                toJson = JsonConvert.DeserializeObject(webClient.DownloadString($"https://oauth.vk.com/token?grant_type=password&client_id=3697615&client_secret=AlVXZFMUqyrnABp8ncuU&username={username.ToString()}&password={password.ToString()}&v=5.92&2fa_supported=1"));

                Token = toJson["access_token"];
            }
            catch { return null; }
            return Token;
        }
        public string GetInfo()
        {
            dynamic JSON = JsonConvert.DeserializeObject(SendMethods("users.get", "", Token));
            FirstName = JSON["first_name"];

            return FirstName;
        }
        public static string SendMethods(string methods, string arguments, string token)
        {
            string response = Helper.sendRequest($"https://api.vk.com/api.php?oauth=1&method={methods.ToString()}&{arguments}&v=5.95&access_token={token.ToString()}").Result;
            if (response.Contains("Captcha needed"))
            {
                dynamic json = JsonConvert.DeserializeObject(response);
                Log.Push("Капча...");
                string captcha_sid = Convert.ToString(json["error"]["captcha_sid"]);
                var captcha_key = solveCaptcha(Convert.ToString(json["error"]["captcha_img"]));
                Log.Push($"Решено - {captcha_key}");
                return Helper.sendRequest($"https://api.vk.com/api.php?oauth=1&method={methods}&{arguments}&access_token={token.ToString()}&captcha_sid={captcha_sid}&captcha_key={captcha_key}&v=5.95").Result;
            }
            return response;
        }
     

        private static string solveCaptcha(string url)
        {
            string solvedStr = string.Empty;
            string fileName = new Random().Next(0, 155).ToString() + ".png";
            using (var webClient = new WebClient())
            {
                webClient.DownloadFile(url, $"tmp\\{fileName}");
            }
            string api_key = File.ReadAllText("key.txt");
            RuCaptchaClient ruCaptchaClient = new RuCaptchaClient(api_key);
            var captchaID = string.Empty;
            try
            {
                captchaID = ruCaptchaClient.UploadCaptchaFile($"tmp\\{fileName}");
            }
            catch { }
            while (string.IsNullOrEmpty(solvedStr))
            {
                try
                {
                    solvedStr = ruCaptchaClient.GetCaptcha(captchaID);
                }
                catch { }
                Thread.Sleep(1000);
            }
            File.Delete($"tmp\\{fileName}");
            return solvedStr;
        }
    }
    class Helper
    {
        public static async Task<string> sendRequest(string url)
        {
            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
            httpWebRequest.Method = "GET";
            HttpWebResponse httpWebResponse = (HttpWebResponse)await httpWebRequest.GetResponseAsync();
            Stream stream = httpWebResponse.GetResponseStream();
            StreamReader streamReader = new StreamReader(stream, Encoding.UTF8);
            return streamReader.ReadToEnd();
        }
    }
}
