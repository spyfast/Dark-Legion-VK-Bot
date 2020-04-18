namespace DarkLegion
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.currentAccounts = new System.Windows.Forms.ComboBox();
            this.dataGridViewFlooder = new System.Windows.Forms.DataGridView();
            this.target = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.abouts = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aboutsType = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.numericFlooder = new System.Windows.Forms.NumericUpDown();
            this.balanceCaptcha = new System.Windows.Forms.Label();
            this.LogTimer = new System.Windows.Forms.Timer(this.components);
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.numericChat = new System.Windows.Forms.NumericUpDown();
            this.chatTarget = new System.Windows.Forms.DataGridView();
            this.targetChat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameTo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.removeAvatar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.LogOff = new MaterialSkin.Controls.MaterialCheckBox();
            this.BotStart_Stop = new MaterialSkin.Controls.MaterialRaisedButton();
            this.getBalanceReCaptcha = new MaterialSkin.Controls.MaterialRaisedButton();
            this.AddKeyCaptcha = new MaterialSkin.Controls.MaterialRaisedButton();
            this.text_Captcha = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.enabledFlooder = new MaterialSkin.Controls.MaterialCheckBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.SaveBtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.BalanceReCaptcha = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.enabledChat = new MaterialSkin.Controls.MaterialCheckBox();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.Savechats = new MaterialSkin.Controls.MaterialRaisedButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFlooder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericFlooder)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericChat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chatTarget)).BeginInit();
            this.SuspendLayout();
            // 
            // currentAccounts
            // 
            this.currentAccounts.FormattingEnabled = true;
            this.currentAccounts.Location = new System.Drawing.Point(148, 70);
            this.currentAccounts.Name = "currentAccounts";
            this.currentAccounts.Size = new System.Drawing.Size(436, 21);
            this.currentAccounts.TabIndex = 0;
            this.currentAccounts.SelectedIndexChanged += new System.EventHandler(this.CurrentAccounts_SelectedIndexChanged);
            // 
            // dataGridViewFlooder
            // 
            this.dataGridViewFlooder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFlooder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.target,
            this.abouts,
            this.aboutsType});
            this.dataGridViewFlooder.Location = new System.Drawing.Point(6, 6);
            this.dataGridViewFlooder.Name = "dataGridViewFlooder";
            this.dataGridViewFlooder.Size = new System.Drawing.Size(543, 150);
            this.dataGridViewFlooder.TabIndex = 3;
            // 
            // target
            // 
            this.target.HeaderText = "Цель";
            this.target.Name = "target";
            this.target.Width = 150;
            // 
            // abouts
            // 
            this.abouts.HeaderText = "Обращение";
            this.abouts.Name = "abouts";
            this.abouts.Width = 150;
            // 
            // aboutsType
            // 
            this.aboutsType.HeaderText = "Расположение обращения";
            this.aboutsType.Items.AddRange(new object[] {
            "В начале",
            "В конце"});
            this.aboutsType.Name = "aboutsType";
            this.aboutsType.Width = 200;
            // 
            // numericFlooder
            // 
            this.numericFlooder.Location = new System.Drawing.Point(6, 240);
            this.numericFlooder.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numericFlooder.Minimum = new decimal(new int[] {
            333,
            0,
            0,
            0});
            this.numericFlooder.Name = "numericFlooder";
            this.numericFlooder.Size = new System.Drawing.Size(153, 20);
            this.numericFlooder.TabIndex = 1;
            this.numericFlooder.Value = new decimal(new int[] {
            333,
            0,
            0,
            0});
            // 
            // balanceCaptcha
            // 
            this.balanceCaptcha.AutoSize = true;
            this.balanceCaptcha.Location = new System.Drawing.Point(445, 388);
            this.balanceCaptcha.Name = "balanceCaptcha";
            this.balanceCaptcha.Size = new System.Drawing.Size(0, 13);
            this.balanceCaptcha.TabIndex = 6;
            // 
            // LogTimer
            // 
            this.LogTimer.Enabled = true;
            this.LogTimer.Interval = 1000;
            this.LogTimer.Tick += new System.EventHandler(this.LogTimer_Tick);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 448);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.richTextBox1.Size = new System.Drawing.Size(561, 87);
            this.richTextBox1.TabIndex = 11;
            this.richTextBox1.Text = "";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 96);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(572, 289);
            this.tabControl1.TabIndex = 13;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.BalanceReCaptcha);
            this.tabPage1.Controls.Add(this.materialLabel2);
            this.tabPage1.Controls.Add(this.SaveBtn);
            this.tabPage1.Controls.Add(this.materialLabel1);
            this.tabPage1.Controls.Add(this.enabledFlooder);
            this.tabPage1.Controls.Add(this.dataGridViewFlooder);
            this.tabPage1.Controls.Add(this.numericFlooder);
            this.tabPage1.ForeColor = System.Drawing.Color.Black;
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(564, 263);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Флудер";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.Savechats);
            this.tabPage2.Controls.Add(this.materialLabel4);
            this.tabPage2.Controls.Add(this.enabledChat);
            this.tabPage2.Controls.Add(this.numericChat);
            this.tabPage2.Controls.Add(this.chatTarget);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(564, 263);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Беседы";
            // 
            // numericChat
            // 
            this.numericChat.Location = new System.Drawing.Point(6, 208);
            this.numericChat.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericChat.Minimum = new decimal(new int[] {
            333,
            0,
            0,
            0});
            this.numericChat.Name = "numericChat";
            this.numericChat.Size = new System.Drawing.Size(120, 20);
            this.numericChat.TabIndex = 3;
            this.numericChat.Value = new decimal(new int[] {
            333,
            0,
            0,
            0});
            // 
            // chatTarget
            // 
            this.chatTarget.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.chatTarget.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.targetChat,
            this.nameTo,
            this.removeAvatar});
            this.chatTarget.Location = new System.Drawing.Point(6, 6);
            this.chatTarget.Name = "chatTarget";
            this.chatTarget.Size = new System.Drawing.Size(551, 177);
            this.chatTarget.TabIndex = 0;
            // 
            // targetChat
            // 
            this.targetChat.HeaderText = "Ссылка на цель";
            this.targetChat.Name = "targetChat";
            this.targetChat.Width = 200;
            // 
            // nameTo
            // 
            this.nameTo.HeaderText = "Изменять название на";
            this.nameTo.Name = "nameTo";
            this.nameTo.Width = 200;
            // 
            // removeAvatar
            // 
            this.removeAvatar.HeaderText = "Удалять аватар";
            this.removeAvatar.Name = "removeAvatar";
            this.removeAvatar.Width = 108;
            // 
            // LogOff
            // 
            this.LogOff.AutoSize = true;
            this.LogOff.BackColor = System.Drawing.Color.Red;
            this.LogOff.Depth = 0;
            this.LogOff.Font = new System.Drawing.Font("Roboto", 10F);
            this.LogOff.Location = new System.Drawing.Point(12, 538);
            this.LogOff.Margin = new System.Windows.Forms.Padding(0);
            this.LogOff.MouseLocation = new System.Drawing.Point(-1, -1);
            this.LogOff.MouseState = MaterialSkin.MouseState.HOVER;
            this.LogOff.Name = "LogOff";
            this.LogOff.Ripple = true;
            this.LogOff.Size = new System.Drawing.Size(128, 30);
            this.LogOff.TabIndex = 14;
            this.LogOff.Text = "Отключить лог";
            this.LogOff.UseVisualStyleBackColor = false;
            this.LogOff.CheckedChanged += new System.EventHandler(this.LogOff_CheckedChanged);
            // 
            // BotStart_Stop
            // 
            this.BotStart_Stop.Depth = 0;
            this.BotStart_Stop.Location = new System.Drawing.Point(12, 387);
            this.BotStart_Stop.MouseState = MaterialSkin.MouseState.HOVER;
            this.BotStart_Stop.Name = "BotStart_Stop";
            this.BotStart_Stop.Primary = true;
            this.BotStart_Stop.Size = new System.Drawing.Size(316, 26);
            this.BotStart_Stop.TabIndex = 15;
            this.BotStart_Stop.Text = "Запуск";
            this.BotStart_Stop.UseVisualStyleBackColor = true;
            this.BotStart_Stop.Click += new System.EventHandler(this.BotStart_Stop_Click);
            // 
            // getBalanceReCaptcha
            // 
            this.getBalanceReCaptcha.Depth = 0;
            this.getBalanceReCaptcha.Location = new System.Drawing.Point(334, 388);
            this.getBalanceReCaptcha.MouseState = MaterialSkin.MouseState.HOVER;
            this.getBalanceReCaptcha.Name = "getBalanceReCaptcha";
            this.getBalanceReCaptcha.Primary = true;
            this.getBalanceReCaptcha.Size = new System.Drawing.Size(239, 26);
            this.getBalanceReCaptcha.TabIndex = 16;
            this.getBalanceReCaptcha.Text = "Узнать баланс Антикапчи";
            this.getBalanceReCaptcha.UseVisualStyleBackColor = true;
            this.getBalanceReCaptcha.Click += new System.EventHandler(this.GetBalanceReCaptcha_Click);
            // 
            // AddKeyCaptcha
            // 
            this.AddKeyCaptcha.Depth = 0;
            this.AddKeyCaptcha.Location = new System.Drawing.Point(334, 416);
            this.AddKeyCaptcha.MouseState = MaterialSkin.MouseState.HOVER;
            this.AddKeyCaptcha.Name = "AddKeyCaptcha";
            this.AddKeyCaptcha.Primary = true;
            this.AddKeyCaptcha.Size = new System.Drawing.Size(239, 26);
            this.AddKeyCaptcha.TabIndex = 17;
            this.AddKeyCaptcha.Text = "Добавить ключ антикапчи";
            this.AddKeyCaptcha.UseVisualStyleBackColor = true;
            this.AddKeyCaptcha.Click += new System.EventHandler(this.AddKeyCaptcha_Click);
            // 
            // text_Captcha
            // 
            this.text_Captcha.BackColor = System.Drawing.Color.White;
            this.text_Captcha.Depth = 0;
            this.text_Captcha.Hint = "Введите ключ антикапчи";
            this.text_Captcha.Location = new System.Drawing.Point(12, 419);
            this.text_Captcha.MouseState = MaterialSkin.MouseState.HOVER;
            this.text_Captcha.Name = "text_Captcha";
            this.text_Captcha.PasswordChar = '\0';
            this.text_Captcha.SelectedText = "";
            this.text_Captcha.SelectionLength = 0;
            this.text_Captcha.SelectionStart = 0;
            this.text_Captcha.Size = new System.Drawing.Size(275, 23);
            this.text_Captcha.TabIndex = 18;
            this.text_Captcha.UseSystemPasswordChar = false;
            // 
            // enabledFlooder
            // 
            this.enabledFlooder.AutoSize = true;
            this.enabledFlooder.BackColor = System.Drawing.Color.Red;
            this.enabledFlooder.Depth = 0;
            this.enabledFlooder.Font = new System.Drawing.Font("Roboto", 10F);
            this.enabledFlooder.Location = new System.Drawing.Point(421, 159);
            this.enabledFlooder.Margin = new System.Windows.Forms.Padding(0);
            this.enabledFlooder.MouseLocation = new System.Drawing.Point(-1, -1);
            this.enabledFlooder.MouseState = MaterialSkin.MouseState.HOVER;
            this.enabledFlooder.Name = "enabledFlooder";
            this.enabledFlooder.Ripple = true;
            this.enabledFlooder.Size = new System.Drawing.Size(84, 30);
            this.enabledFlooder.TabIndex = 15;
            this.enabledFlooder.Text = "Активен";
            this.enabledFlooder.UseVisualStyleBackColor = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(6, 218);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(118, 19);
            this.materialLabel1.TabIndex = 16;
            this.materialLabel1.Text = "Задержка в мс:";
            // 
            // SaveBtn
            // 
            this.SaveBtn.Depth = 0;
            this.SaveBtn.Location = new System.Drawing.Point(6, 159);
            this.SaveBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Primary = true;
            this.SaveBtn.Size = new System.Drawing.Size(412, 26);
            this.SaveBtn.TabIndex = 19;
            this.SaveBtn.Text = "Сохранить";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(6, 199);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(110, 19);
            this.materialLabel2.TabIndex = 20;
            this.materialLabel2.Text = "Баланс капчи:";
            // 
            // BalanceReCaptcha
            // 
            this.BalanceReCaptcha.AutoSize = true;
            this.BalanceReCaptcha.Depth = 0;
            this.BalanceReCaptcha.Font = new System.Drawing.Font("Roboto", 11F);
            this.BalanceReCaptcha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BalanceReCaptcha.Location = new System.Drawing.Point(115, 199);
            this.BalanceReCaptcha.MouseState = MaterialSkin.MouseState.HOVER;
            this.BalanceReCaptcha.Name = "BalanceReCaptcha";
            this.BalanceReCaptcha.Size = new System.Drawing.Size(16, 19);
            this.BalanceReCaptcha.TabIndex = 21;
            this.BalanceReCaptcha.Text = "?";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(8, 69);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(134, 19);
            this.materialLabel3.TabIndex = 19;
            this.materialLabel3.Text = "Текущий аккаунт:";
            // 
            // enabledChat
            // 
            this.enabledChat.AutoSize = true;
            this.enabledChat.BackColor = System.Drawing.Color.Red;
            this.enabledChat.Depth = 0;
            this.enabledChat.Font = new System.Drawing.Font("Roboto", 10F);
            this.enabledChat.Location = new System.Drawing.Point(473, 227);
            this.enabledChat.Margin = new System.Windows.Forms.Padding(0);
            this.enabledChat.MouseLocation = new System.Drawing.Point(-1, -1);
            this.enabledChat.MouseState = MaterialSkin.MouseState.HOVER;
            this.enabledChat.Name = "enabledChat";
            this.enabledChat.Ripple = true;
            this.enabledChat.Size = new System.Drawing.Size(84, 30);
            this.enabledChat.TabIndex = 16;
            this.enabledChat.Text = "Активен";
            this.enabledChat.UseVisualStyleBackColor = false;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(3, 186);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(118, 19);
            this.materialLabel4.TabIndex = 20;
            this.materialLabel4.Text = "Задержка в мс:";
            // 
            // Savechats
            // 
            this.Savechats.Depth = 0;
            this.Savechats.Location = new System.Drawing.Point(7, 231);
            this.Savechats.MouseState = MaterialSkin.MouseState.HOVER;
            this.Savechats.Name = "Savechats";
            this.Savechats.Primary = true;
            this.Savechats.Size = new System.Drawing.Size(463, 26);
            this.Savechats.TabIndex = 21;
            this.Savechats.Text = "Сохранить";
            this.Savechats.UseVisualStyleBackColor = true;
            this.Savechats.Click += new System.EventHandler(this.Savechats_Click_1);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(592, 582);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.text_Captcha);
            this.Controls.Add(this.AddKeyCaptcha);
            this.Controls.Add(this.getBalanceReCaptcha);
            this.Controls.Add(this.BotStart_Stop);
            this.Controls.Add(this.LogOff);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.balanceCaptcha);
            this.Controls.Add(this.currentAccounts);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dark Legion";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFlooder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericFlooder)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericChat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chatTarget)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox currentAccounts;
        private System.Windows.Forms.NumericUpDown numericFlooder;
        public System.Windows.Forms.DataGridView dataGridViewFlooder;
        private System.Windows.Forms.Label balanceCaptcha;
        private System.Windows.Forms.DataGridViewTextBoxColumn target;
        private System.Windows.Forms.DataGridViewTextBoxColumn abouts;
        private System.Windows.Forms.DataGridViewComboBoxColumn aboutsType;
        private System.Windows.Forms.Timer LogTimer;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.NumericUpDown numericChat;
        private System.Windows.Forms.DataGridView chatTarget;
        private System.Windows.Forms.DataGridViewTextBoxColumn targetChat;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameTo;
        private System.Windows.Forms.DataGridViewCheckBoxColumn removeAvatar;
        private MaterialSkin.Controls.MaterialCheckBox LogOff;
        private MaterialSkin.Controls.MaterialRaisedButton BotStart_Stop;
        private MaterialSkin.Controls.MaterialRaisedButton getBalanceReCaptcha;
        private MaterialSkin.Controls.MaterialRaisedButton AddKeyCaptcha;
        private MaterialSkin.Controls.MaterialSingleLineTextField text_Captcha;
        private MaterialSkin.Controls.MaterialRaisedButton SaveBtn;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialCheckBox enabledFlooder;
        private MaterialSkin.Controls.MaterialLabel BalanceReCaptcha;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialCheckBox enabledChat;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialRaisedButton Savechats;
    }
}

