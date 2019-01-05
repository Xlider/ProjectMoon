namespace Project_Moon
{
    partial class ChangeProfile
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
            this.TopPanel = new System.Windows.Forms.Panel();
            this._CloseButton = new CustomWindowsForm.ButtonZ();
            this.LabelChangeProfile = new System.Windows.Forms.Label();
            this.LabelLogin = new System.Windows.Forms.Label();
            this.LabelProfilePassword = new System.Windows.Forms.Label();
            this.TextLogin = new System.Windows.Forms.TextBox();
            this.LabelUse1 = new System.Windows.Forms.Label();
            this.LabelUse2 = new System.Windows.Forms.Label();
            this.LabelForgotPassword = new System.Windows.Forms.Label();
            this.TextPassword = new System.Windows.Forms.TextBox();
            this.LabelInvalid2 = new System.Windows.Forms.Label();
            this.LabelInvalid1 = new System.Windows.Forms.Label();
            this.ButtonLogin = new CustomWindowsForm.ButtonZ();
            this.TopPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(80)))));
            this.TopPanel.Controls.Add(this._CloseButton);
            this.TopPanel.Controls.Add(this.LabelChangeProfile);
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(256, 40);
            this.TopPanel.TabIndex = 0;
            this.TopPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseMove);
            this.TopPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseDown);
            this.TopPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseUp);
            // 
            // _CloseButton
            // 
            this._CloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._CloseButton.BZBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(80)))));
            this._CloseButton.DisplayText = "X";
            this._CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._CloseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this._CloseButton.ForeColor = System.Drawing.Color.White;
            this._CloseButton.Location = new System.Drawing.Point(219, 2);
            this._CloseButton.MouseClickColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this._CloseButton.MouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(80)))), ((int)(((byte)(180)))));
            this._CloseButton.Name = "_CloseButton";
            this._CloseButton.Size = new System.Drawing.Size(35, 35);
            this._CloseButton.TabIndex = 1;
            this._CloseButton.Text = "X";
            this._CloseButton.TextLocation_X = 10;
            this._CloseButton.TextLocation_Y = 4;
            this._CloseButton.UseVisualStyleBackColor = true;
            this._CloseButton.Click += new System.EventHandler(this._CloseButton_Click);
            // 
            // LabelChangeProfile
            // 
            this.LabelChangeProfile.AutoSize = true;
            this.LabelChangeProfile.Font = new System.Drawing.Font("Swis721 Blk BT", 12.25F);
            this.LabelChangeProfile.ForeColor = System.Drawing.Color.White;
            this.LabelChangeProfile.Location = new System.Drawing.Point(9, 10);
            this.LabelChangeProfile.Name = "LabelChangeProfile";
            this.LabelChangeProfile.Size = new System.Drawing.Size(149, 20);
            this.LabelChangeProfile.TabIndex = 0;
            this.LabelChangeProfile.Text = "Change Profile";
            // 
            // LabelLogin
            // 
            this.LabelLogin.AutoSize = true;
            this.LabelLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.LabelLogin.ForeColor = System.Drawing.Color.White;
            this.LabelLogin.Location = new System.Drawing.Point(25, 68);
            this.LabelLogin.Name = "LabelLogin";
            this.LabelLogin.Size = new System.Drawing.Size(53, 17);
            this.LabelLogin.TabIndex = 4;
            this.LabelLogin.Text = "Handle";
            // 
            // LabelProfilePassword
            // 
            this.LabelProfilePassword.AutoSize = true;
            this.LabelProfilePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.LabelProfilePassword.ForeColor = System.Drawing.Color.White;
            this.LabelProfilePassword.Location = new System.Drawing.Point(25, 106);
            this.LabelProfilePassword.Name = "LabelProfilePassword";
            this.LabelProfilePassword.Size = new System.Drawing.Size(69, 17);
            this.LabelProfilePassword.TabIndex = 5;
            this.LabelProfilePassword.Text = "Password";
            // 
            // TextLogin
            // 
            this.TextLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(150)))));
            this.TextLogin.ForeColor = System.Drawing.Color.White;
            this.TextLogin.Location = new System.Drawing.Point(133, 65);
            this.TextLogin.MaxLength = 30;
            this.TextLogin.Name = "TextLogin";
            this.TextLogin.Size = new System.Drawing.Size(100, 20);
            this.TextLogin.TabIndex = 1;
            this.TextLogin.TextChanged += new System.EventHandler(this.TextLogin_TextChanged);
            // 
            // LabelUse1
            // 
            this.LabelUse1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelUse1.AutoSize = true;
            this.LabelUse1.ForeColor = System.Drawing.Color.DimGray;
            this.LabelUse1.Location = new System.Drawing.Point(128, 181);
            this.LabelUse1.Name = "LabelUse1";
            this.LabelUse1.Size = new System.Drawing.Size(40, 13);
            this.LabelUse1.TabIndex = 8;
            this.LabelUse1.Text = "Use ID";
            this.LabelUse1.MouseLeave += new System.EventHandler(this.LabelUse1_MouseLeave);
            this.LabelUse1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.LabelUse1_MouseClick);
            this.LabelUse1.MouseHover += new System.EventHandler(this.LabelUse1_MouseHover);
            // 
            // LabelUse2
            // 
            this.LabelUse2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelUse2.AutoSize = true;
            this.LabelUse2.ForeColor = System.Drawing.Color.DimGray;
            this.LabelUse2.Location = new System.Drawing.Point(189, 181);
            this.LabelUse2.Name = "LabelUse2";
            this.LabelUse2.Size = new System.Drawing.Size(54, 13);
            this.LabelUse2.TabIndex = 7;
            this.LabelUse2.Text = "Use Email";
            this.LabelUse2.MouseLeave += new System.EventHandler(this.LabelUse2_MouseLeave);
            this.LabelUse2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.LabelUse2_MouseClick);
            this.LabelUse2.MouseHover += new System.EventHandler(this.LabelUse2_MouseHover);
            // 
            // LabelForgotPassword
            // 
            this.LabelForgotPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelForgotPassword.AutoSize = true;
            this.LabelForgotPassword.ForeColor = System.Drawing.Color.DimGray;
            this.LabelForgotPassword.Location = new System.Drawing.Point(130, 154);
            this.LabelForgotPassword.Name = "LabelForgotPassword";
            this.LabelForgotPassword.Size = new System.Drawing.Size(114, 13);
            this.LabelForgotPassword.TabIndex = 6;
            this.LabelForgotPassword.Text = "Forgot your password?";
            this.LabelForgotPassword.MouseLeave += new System.EventHandler(this.LabelForgotPassword_MouseLeave);
            this.LabelForgotPassword.MouseHover += new System.EventHandler(this.LabelForgotPassword_MouseHover);
            // 
            // TextPassword
            // 
            this.TextPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(150)))));
            this.TextPassword.ForeColor = System.Drawing.Color.White;
            this.TextPassword.Location = new System.Drawing.Point(133, 106);
            this.TextPassword.MaxLength = 18;
            this.TextPassword.Name = "TextPassword";
            this.TextPassword.Size = new System.Drawing.Size(100, 20);
            this.TextPassword.TabIndex = 2;
            this.TextPassword.UseSystemPasswordChar = true;
            this.TextPassword.TextChanged += new System.EventHandler(this.TextPassword_TextChanged);
            // 
            // LabelInvalid2
            // 
            this.LabelInvalid2.AutoSize = true;
            this.LabelInvalid2.ForeColor = System.Drawing.Color.Red;
            this.LabelInvalid2.Location = new System.Drawing.Point(131, 129);
            this.LabelInvalid2.Name = "LabelInvalid2";
            this.LabelInvalid2.Size = new System.Drawing.Size(0, 13);
            this.LabelInvalid2.TabIndex = 9;
            // 
            // LabelInvalid1
            // 
            this.LabelInvalid1.AutoSize = true;
            this.LabelInvalid1.ForeColor = System.Drawing.Color.Red;
            this.LabelInvalid1.Location = new System.Drawing.Point(131, 88);
            this.LabelInvalid1.Name = "LabelInvalid1";
            this.LabelInvalid1.Size = new System.Drawing.Size(0, 13);
            this.LabelInvalid1.TabIndex = 10;
            // 
            // ButtonLogin
            // 
            this.ButtonLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ButtonLogin.BZBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(80)))));
            this.ButtonLogin.DisplayText = "LOGIN";
            this.ButtonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold);
            this.ButtonLogin.ForeColor = System.Drawing.Color.White;
            this.ButtonLogin.Location = new System.Drawing.Point(28, 171);
            this.ButtonLogin.MouseClickColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(180)))), ((int)(((byte)(200)))));
            this.ButtonLogin.MouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(140)))));
            this.ButtonLogin.Name = "ButtonLogin";
            this.ButtonLogin.Size = new System.Drawing.Size(76, 23);
            this.ButtonLogin.TabIndex = 3;
            this.ButtonLogin.Text = "LOGIN";
            this.ButtonLogin.TextLocation_X = 11;
            this.ButtonLogin.TextLocation_Y = 2;
            this.ButtonLogin.UseVisualStyleBackColor = true;
            this.ButtonLogin.Click += new System.EventHandler(this.ButtonLogin_Click);
            // 
            // ChangeProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(150)))));
            this.ClientSize = new System.Drawing.Size(256, 206);
            this.Controls.Add(this.LabelInvalid1);
            this.Controls.Add(this.LabelInvalid2);
            this.Controls.Add(this.ButtonLogin);
            this.Controls.Add(this.LabelForgotPassword);
            this.Controls.Add(this.LabelUse2);
            this.Controls.Add(this.LabelUse1);
            this.Controls.Add(this.TextPassword);
            this.Controls.Add(this.TextLogin);
            this.Controls.Add(this.LabelProfilePassword);
            this.Controls.Add(this.LabelLogin);
            this.Controls.Add(this.TopPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChangeProfile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChangeProfile";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.ChangeProfile_Load);
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Label LabelChangeProfile;
        private System.Windows.Forms.Label LabelLogin;
        private System.Windows.Forms.Label LabelProfilePassword;
        private System.Windows.Forms.TextBox TextLogin;
        private System.Windows.Forms.Label LabelUse1;
        private System.Windows.Forms.Label LabelUse2;
        private System.Windows.Forms.Label LabelForgotPassword;
        private CustomWindowsForm.ButtonZ ButtonLogin;
        private System.Windows.Forms.TextBox TextPassword;
        private System.Windows.Forms.Label LabelInvalid2;
        private System.Windows.Forms.Label LabelInvalid1;
        private CustomWindowsForm.ButtonZ _CloseButton;
    }
}