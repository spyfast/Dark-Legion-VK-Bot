using System;
using System.IO;
using System.Management;
using System.Net;
using System.Text;
using System.Windows.Forms;
using DarkLegion.Properties;
using MaterialSkin.Controls;

namespace DarkLegion
{
    public partial class AuthForm : MaterialForm
    {
        private string hwid_text = String.Empty;
        public AuthForm()
        {
            InitializeComponent();
            password_hwid.Text = Settings.Default["password_hwid"].ToString();
            SavePassword.Checked = Settings.Default.CheckSettings;
        }
        private string get_Hwid(string hwid_text)
        {
            string hwid = string.Empty;
            foreach (char c in hwid_text)
            {
                hwid += (char)((int)c ^ 1);
            }
            return hwid;
        }
        private void AuthForm_Load(object sender, EventArgs e)
        {
            try
            {
                string Get_HWID = Environment.GetFolderPath(Environment.SpecialFolder.System).Substring(0, 1);
                ManagementObject Get_Disk = new ManagementObject("win32_logicaldisk.deviceid=\"" + Get_HWID + ":\"");
                Get_Disk.Get();
                string disk = (Get_Disk["VolumeSerialNumber"].ToString());
                string HWID_Text = (get_Hwid(disk.ToString()));
                hwid.Text = HWID_Text;

            }
            catch (Exception)
            {
                hwid.Text = "Error Server.";
            }
        }
        private void AuthForm_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void Enter_hwid_Click(object sender, EventArgs e)
        {
            if (password_hwid.Text == "")
                MessageBox.Show("Username не указан!", "Dark Legion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                String password = "log=admin&pas=admin";
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create("");
                request.UserAgent = "Mozilla/5.0";
                request.Method = "POST";
                request.ContentType = "application/x-www-form-urlencoded";
                byte[] EncodedPostParams = Encoding.ASCII.GetBytes(password);
                request.ContentLength = EncodedPostParams.Length;
                request.GetRequestStream().Write(EncodedPostParams, 0, EncodedPostParams.Length);
                request.GetRequestStream().Close();
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                string html = new StreamReader(response.GetResponseStream(), Encoding.GetEncoding("windows-1251")).ReadToEnd();
                string[] stringSeparators = new string[] { "\n" };
                string[] result = html.Split(stringSeparators, StringSplitOptions.RemoveEmptyEntries);
                string Number = "";
                foreach (string hwid_tExt in result)
                {
                    if (hwid_tExt.IndexOf(password_hwid.Text) != -1)
                    {
                        string[] Stroka_Hwid = hwid_tExt.ToString().Split((Convert.ToChar(":")));

                        string reLoL0 = (get_Hwid(Stroka_Hwid[1].ToString()));
                        Number = reLoL0.ToString();

                    }
                }
                if (Number == "")
                {
                    MessageBox.Show("Не существует в базе данных!", "Dark Legion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();
                }
                else
                {
                    string HoldingAdress = "";
                    try
                    {
                        string drive = Environment.GetFolderPath(Environment.SpecialFolder.System).Substring(0, 1);
                        ManagementObject disk = new ManagementObject("win32_logicaldisk.deviceid=\"" + drive + ":\"");
                        disk.Get();
                        string diskLetter = (disk["VolumeSerialNumber"].ToString());
                        HoldingAdress = diskLetter;

                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Возникла критическая ошибка, автозакрытие приложения 0х01", "Dark Legion", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    string hwid = Number.Substring(0, 8);
                    if (HoldingAdress == hwid)
                    {
                        if (SavePassword.Checked)
                        {
                            Settings.Default["password_hwid"] = password_hwid.Text;
                            Settings.Default.Save();
                            Settings.Default["CheckSettings"] = SavePassword.Checked;
                            Settings.Default.Save();
                        }
                        MessageBox.Show("Вы вошли как: " + password_hwid.Text, "Dark Legion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        new MainForm().Show();
                        Hide();
                    }
                }
            }
        }
    }
}
