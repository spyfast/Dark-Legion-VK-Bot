using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using System.Xml.Serialization;
using DarkLegion.API.Flooder;
using VkFloods.API.Chat;
using static DarkLegion.MainForm;

namespace DarkLegion.API
{
    public class Account
    {
        public string username { get; set; }
        public string password { get; set; }
        public string token { get; set; }
        public string Name;
        public Account()
        {

        }
        public Account(string username, string password)
        {
            this.username = username;
            this.password = password;
        }
        public string LogIn()
        {
            var token = new API(username, password).LogIn();
            if (string.IsNullOrEmpty(token))
                return "Bad auth";
            this.token = token;
            return token;
        }
        public void Save()
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Account));
            TextWriter textWriter = new StreamWriter($"Accounts\\{username}.xml");
            xmlSerializer.Serialize(textWriter, this);
            textWriter.Close();
        }
        public int delayFlooder { get; set; }
        public string password_hwid { get; set; }
        public readonly Random random = new Random();
        public void WorkFlooder()
        {
            do
            {
                if (flooderTargets.Count == 0)
                {
                    Log.Push("Отсутствуют цели");
                    return;
                }
                var curTarget = random.Next(0, flooderTargets.Count);
                var target = flooderTargets[curTarget].target;
                var about = flooderTargets[curTarget].abouts;
                var typeAbout = flooderTargets[curTarget].aboutsType;
                var listFormatted = phrases.Where(x => !string.IsNullOrEmpty(x)).Distinct().ToList();
                string message = string.Empty;
                switch (typeAbout)
                {
                    case "В начале":
                        message = about + listFormatted[random.Next(0, listFormatted.Count)];
                        break;
                    case "В конце":
                        message = listFormatted[random.Next(0, listFormatted.Count)] + about;
                        break;
                }
                if (target.StartsWith("im?sel="))
                {
                    var match = new Regex("im\\?sel=([0-9]+)").Match(target);
                    if (match.Success)
                    {
                        API.SendMethods("messages.send", $"random_id&user_id={match.Groups[1].Value.ToString()}&message={message}", token);
                        Log.Push($"Отправлено {message} в im?sel={match.Groups[1]}");
                    }
                }
                if (target.StartsWith("im?sel=c"))
                {
                    var match = new Regex("im\\?sel=c([0-9]+)").Match(target);
                    if (match.Success)
                    {
                        API.SendMethods("messages.send", $"random_id&chat_id={match.Groups[1].Value.ToString()}&message={message}", token);
                        Log.Push($"Отправлено {message} в im?sel=c{match.Groups[1]}");
                    }
                }
                Thread.Sleep(delayFlooder);
            } while (enabledFlooder && works);
        }       
        public string KeyCaptcha { get; set; }
        public bool enabledFlooder { get; set; }
        public bool enabledChat { get; set; }
        public static bool works { get; set; }
        public void WorkAsync()
        {

        }
        
        public List<FlooderTargets> flooderTargets = new List<FlooderTargets>();
        public void SetGrid(DataGridViewRowCollection dataGridView)
        {
            flooderTargets.Clear();
            foreach (var obj in dataGridView)
            {
                DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
                if (dataGridViewRow.Cells[1].Value != null)
                {
                    flooderTargets.Add(new FlooderTargets(
                        (dataGridViewRow.Cells[0].Value ?? "").ToString(), 
                        dataGridViewRow.Cells[1].Value.ToString(), 
                        dataGridViewRow.Cells[2].Value.ToString()));
                }
            }
        }
        public List<ChatConfig> chatConfigs = new List<ChatConfig>();
        public void SetGridChat(DataGridViewRowCollection dataGridView)
        {
            chatConfigs.Clear();
            foreach (var obj in dataGridView)
            {
                DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
                if (dataGridViewRow.Cells[1].Value != null)
                {
                    chatConfigs.Add(new ChatConfig((dataGridViewRow.Cells[0].Value ?? "").ToString(), 
                        (dataGridViewRow.Cells[1].Value ?? "").ToString(), 
                        Convert.ToBoolean(dataGridViewRow.Cells[2].Value ?? "")));
                }
            }
        }
        public int delayChat { get; set; }
        public void WorkChat()
        {
            do
            {
                WorkChats(random.Next(0, chatConfigs.Count));
                Thread.Sleep(delayChat);

            } while (enabledChat && works);
        }
        
        public void WorkChats(int i)
        {
            var target = chatConfigs[i].chatTarget;
            var nameTo = chatConfigs[i].nameTo;
            var needRemoveAvatar = chatConfigs[i].removeAvatar;
            var matchID = new Regex("im\\?sel=c([0-9]+)").Match(target);
            if (matchID.Success)
            {
                var parseID = matchID.Groups[1].Value;
                string content = string.Empty;
                if (!needRemoveAvatar)
                    content = $"var msg = API.messages.editChat({{\"chat_id\": {parseID}, \"title\": \"{nameTo}\"}});\r\nreturn msg;";
                else
                    content = $"var msg = API.messages.editChat({{\"chat_id\": {parseID}, \"title\": \"{nameTo}\"}});\r\nvar avt = API.messages.deleteChatPhoto({{\"chat_id\": {parseID}}});\r\nreturn msg;";
                API.SendMethods("execute", $"code={content}", token);
                Log.Push($"[{username}]: Название беседы изменено на: {nameTo}");
            }
        }
    }
}
