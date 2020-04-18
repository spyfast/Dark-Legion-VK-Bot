namespace DarkLegion
{
    partial class AuthForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SavePassword = new MaterialSkin.Controls.MaterialCheckBox();
            this.enter_hwid = new MaterialSkin.Controls.MaterialRaisedButton();
            this.hwid = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.password_hwid = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.SuspendLayout();
            // 
            // SavePassword
            // 
            this.SavePassword.AutoSize = true;
            this.SavePassword.Depth = 0;
            this.SavePassword.Font = new System.Drawing.Font("Roboto", 10F);
            this.SavePassword.Location = new System.Drawing.Point(9, 123);
            this.SavePassword.Margin = new System.Windows.Forms.Padding(0);
            this.SavePassword.MouseLocation = new System.Drawing.Point(-1, -1);
            this.SavePassword.MouseState = MaterialSkin.MouseState.HOVER;
            this.SavePassword.Name = "SavePassword";
            this.SavePassword.Ripple = true;
            this.SavePassword.Size = new System.Drawing.Size(138, 30);
            this.SavePassword.TabIndex = 6;
            this.SavePassword.Text = "Запомнить меня";
            this.SavePassword.UseVisualStyleBackColor = true;
            // 
            // enter_hwid
            // 
            this.enter_hwid.Depth = 0;
            this.enter_hwid.Location = new System.Drawing.Point(161, 130);
            this.enter_hwid.MouseState = MaterialSkin.MouseState.HOVER;
            this.enter_hwid.Name = "enter_hwid";
            this.enter_hwid.Primary = true;
            this.enter_hwid.Size = new System.Drawing.Size(196, 23);
            this.enter_hwid.TabIndex = 7;
            this.enter_hwid.Text = "Войти";
            this.enter_hwid.UseVisualStyleBackColor = true;
            this.enter_hwid.Click += new System.EventHandler(this.Enter_hwid_Click);
            // 
            // hwid
            // 
            this.hwid.Depth = 0;
            this.hwid.Hint = "HWID";
            this.hwid.Location = new System.Drawing.Point(12, 68);
            this.hwid.MouseState = MaterialSkin.MouseState.HOVER;
            this.hwid.Name = "hwid";
            this.hwid.PasswordChar = '\0';
            this.hwid.SelectedText = "";
            this.hwid.SelectionLength = 0;
            this.hwid.SelectionStart = 0;
            this.hwid.Size = new System.Drawing.Size(345, 23);
            this.hwid.TabIndex = 8;
            this.hwid.UseSystemPasswordChar = false;
            // 
            // password_hwid
            // 
            this.password_hwid.Depth = 0;
            this.password_hwid.Hint = "Password";
            this.password_hwid.Location = new System.Drawing.Point(12, 97);
            this.password_hwid.MouseState = MaterialSkin.MouseState.HOVER;
            this.password_hwid.Name = "password_hwid";
            this.password_hwid.PasswordChar = '\0';
            this.password_hwid.SelectedText = "";
            this.password_hwid.SelectionLength = 0;
            this.password_hwid.SelectionStart = 0;
            this.password_hwid.Size = new System.Drawing.Size(345, 23);
            this.password_hwid.TabIndex = 9;
            this.password_hwid.UseSystemPasswordChar = false;
            // 
            // AuthForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(369, 180);
            this.Controls.Add(this.password_hwid);
            this.Controls.Add(this.hwid);
            this.Controls.Add(this.enter_hwid);
            this.Controls.Add(this.SavePassword);
            this.MaximizeBox = false;
            this.Name = "AuthForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AuthForm_FormClosing);
            this.Load += new System.EventHandler(this.AuthForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialCheckBox SavePassword;
        private MaterialSkin.Controls.MaterialRaisedButton enter_hwid;
        private MaterialSkin.Controls.MaterialSingleLineTextField hwid;
        private MaterialSkin.Controls.MaterialSingleLineTextField password_hwid;
    }
}