using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;
using DarkLegion.API;
using DarkLegion.RuCaptcha;
using MaterialSkin.Controls;

namespace DarkLegion
{
    public partial class MainForm : MaterialForm
    {
        public MainForm()
        {
            InitializeComponent();
        }
        public List<Account> accounts = new List<Account>();
        public static List<string> phrases = new List<string>();
        public static List<string> accountRus = new List<string>();
        public void MainForm_Shown(object sender, EventArgs e)
        {
            if (!Directory.Exists("Accounts"))
                Directory.CreateDirectory("Accounts");
            if (!Directory.Exists("tmp"))
                Directory.CreateDirectory("tmp");
            if (!File.Exists("accounts.txt"))              
                File.Create("accounts.txt").Close();
            if (!File.Exists("key.txt"))
                File.Create("key.txt").Close();
            if (!File.Exists("phrases.txt"))
                File.Create("phrases.txt").Close();
            string[] getAccs = File.ReadAllLines("accounts.txt", Encoding.GetEncoding("windows-1251"));
            phrases = File.ReadAllLines("phrases.txt", Encoding.GetEncoding("windows-1251")).ToList();
            accountRus = File.ReadAllLines("accounts.txt", Encoding.GetEncoding("windows-1251")).ToList();
            Account account = null;
            for (int i = 0; i < getAccs.Length; i++)
            {
                if (File.Exists($"Accounts\\{getAccs[i].Split(':')[0]}.xml"))
                {
                    FileStream fileStream = new FileStream($"Accounts\\{getAccs[i].Split(':')[0]}.xml", FileMode.Open);
                    XmlReader xmlReader = XmlReader.Create(fileStream);
                    account = (Account)new XmlSerializer(typeof(Account)).Deserialize(xmlReader);
                    fileStream.Close();
                }
                else
                    account = new Account(getAccs[i].Split(':')[0], getAccs[i].Split(':')[1]);
                string token = account.LogIn();
                if (!string.IsNullOrEmpty(token))
                {
                    accounts.Add(account);
                    currentAccounts.Items.Add(getAccs[i].Split(':')[0] + $" {account.Name}");
                }
            }           
            string[] AccountName = File.ReadAllLines("accounts.txt");
            if (AccountName.Length == 0)
                currentAccounts.Text = "Не было загружено ни одного аккаунта.";
            else
                currentAccounts.SelectedIndex = 0;
                CurrentAccounts_SelectedIndexChanged(null, null);
        }



        private void CurrentAccounts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(currentAccounts.SelectedIndex != -1)
            {
                numericFlooder.Value = accounts[currentAccounts.SelectedIndex].delayFlooder > 333 ? accounts[currentAccounts.SelectedIndex].delayFlooder : 333;
                enabledFlooder.Checked = accounts[currentAccounts.SelectedIndex].enabledFlooder;
                enabledChat.Checked = accounts[currentAccounts.SelectedIndex].enabledChat;
                numericChat.Value = accounts[currentAccounts.SelectedIndex].delayChat > 333 ? accounts[currentAccounts.SelectedIndex].delayChat : 333;
                text_Captcha.Text = accounts[currentAccounts.SelectedIndex].KeyCaptcha;
                dataGridViewFlooder.Rows.Clear();
                chatTarget.Rows.Clear();
                for (int i = 0; i < accounts[currentAccounts.SelectedIndex].flooderTargets.Count; i++)
                {
                    dataGridViewFlooder.Rows.Add(
                        accounts[currentAccounts.SelectedIndex].flooderTargets[i].target,
                        accounts[currentAccounts.SelectedIndex].flooderTargets[i].abouts,
                        accounts[currentAccounts.SelectedIndex].flooderTargets[i].aboutsType);
                }
                for (int i = 0; i < accounts[currentAccounts.SelectedIndex].chatConfigs.Count; i++)
                {
                    chatTarget.Rows.Add(
                        accounts[currentAccounts.SelectedIndex].chatConfigs[i].chatTarget,
                        accounts[currentAccounts.SelectedIndex].chatConfigs[i].nameTo,
                        accounts[currentAccounts.SelectedIndex].chatConfigs[i].removeAvatar);
                }
            }
        }

        private void LogTimer_Tick(object sender, EventArgs e)
        {
            while (Log.messages.Count != 0)
            {
                richTextBox1.Text = Log.messages.Dequeue() + "\n" + richTextBox1.Text;
            }
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }


        private void LogOff_CheckedChanged(object sender, EventArgs e)
        {
            if (LogOff.Checked)
            {
                richTextBox1.Enabled = false;
                LogTimer.Enabled = false;
            }
            else
            {
                richTextBox1.Enabled = true;
                LogTimer.Enabled = true;
            }
        }

        private void BotStart_Stop_Click(object sender, EventArgs e)
        {
            try
            {
                string[] phrasesStrok = File.ReadAllLines("phrases.txt");
                if (phrasesStrok.Length == 0)
                    Log.Push("Нет доступных фраз для флуда.");
                else
                if (!Account.works)
                {
                    BotStart_Stop.Text = "Стоп";
                    Account.works = true;
                    if (enabledFlooder.Checked || enabledChat.Enabled)
                    {
                        foreach (var account in accounts)
                        {
                            account.WorkAsync();
                        }
                    }
                }
                else
                {
                    BotStart_Stop.Text = "Запуск";
                    Account.works = false;
                }
            }
            catch { Log.Push("Неизвестная ошибка. Запуск невозможен."); }
        }

        private void GetBalanceReCaptcha_Click(object sender, EventArgs e)
        {
            string[] Get_Balance = File.ReadAllLines("key.txt");
            if (Get_Balance.Length == 0)
                Log.Push("Ключ антикапчи отсутствует.");
            else
                BalanceReCaptcha.Text = new RuCaptchaClient(File.ReadAllText("key.txt")).GetBalance().ToString();
        }

        private void AddKeyCaptcha_Click(object sender, EventArgs e)
        {
            if (text_Captcha.Text.Length > 32)
            {
                Log.Push("Количество символов превышает максимальное значение символов ключа.");
            }
            else
            {
                using (StreamWriter keyReCaptcha = new StreamWriter("key.txt", false))
                {
                    keyReCaptcha.Write(text_Captcha.Text);
                }
            }
            Account account = accounts[currentAccounts.SelectedIndex];
            account.KeyCaptcha = text_Captcha.Text;
            account.Save();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (currentAccounts.SelectedIndex != -1)
            {
                Account account = accounts[currentAccounts.SelectedIndex];
                account.delayFlooder = (int)numericFlooder.Value;
                account.enabledFlooder = enabledFlooder.Checked;
                account.SetGrid(dataGridViewFlooder.Rows);
                account.Save();
            }
        }

        private void Savechats_Click_1(object sender, EventArgs e)
        {
            if (currentAccounts.SelectedIndex != -1)
            {
                Account account = accounts[currentAccounts.SelectedIndex];
                account.delayChat = (int)numericChat.Value;
                account.enabledChat = enabledChat.Checked;
                account.SetGridChat(chatTarget.Rows);
                account.Save();
            }
        }
    }
}
