
namespace Steam.v2
{
    partial class ProfileForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProfileForm));
            this.getInfoLable = new System.Windows.Forms.Label();
            this.replaceBtn = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.nickNameTB = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.loginTB = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.passwordTB = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.avatarImageBX = new System.Windows.Forms.PictureBox();
            this.openBtn = new Guna.UI2.WinForms.Guna2Button();
            this.walletLabel = new System.Windows.Forms.Label();
            this.topUpBtn = new Guna.UI2.WinForms.Guna2Button();
            this.balanceLable = new System.Windows.Forms.Label();
            this.addBalanceTB = new Guna.UI2.WinForms.Guna2TextBox();
            this.acceptBtn = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.avatarImageBX)).BeginInit();
            this.SuspendLayout();
            // 
            // getInfoLable
            // 
            this.getInfoLable.AutoSize = true;
            this.getInfoLable.BackColor = System.Drawing.Color.Transparent;
            this.getInfoLable.Cursor = System.Windows.Forms.Cursors.No;
            this.getInfoLable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.getInfoLable.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.getInfoLable.Location = new System.Drawing.Point(360, 9);
            this.getInfoLable.Name = "getInfoLable";
            this.getInfoLable.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.getInfoLable.Size = new System.Drawing.Size(96, 20);
            this.getInfoLable.TabIndex = 1;
            this.getInfoLable.Text = "Информация ";
            this.getInfoLable.UseCompatibleTextRendering = true;
            // 
            // replaceBtn
            // 
            this.replaceBtn.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.replaceBtn.CheckedState.Parent = this.replaceBtn;
            this.replaceBtn.CustomImages.Parent = this.replaceBtn;
            this.replaceBtn.FillColor = System.Drawing.Color.Gray;
            this.replaceBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.replaceBtn.ForeColor = System.Drawing.Color.Black;
            this.replaceBtn.HoverState.Parent = this.replaceBtn;
            this.replaceBtn.Location = new System.Drawing.Point(54, 260);
            this.replaceBtn.Name = "replaceBtn";
            this.replaceBtn.ShadowDecoration.Parent = this.replaceBtn;
            this.replaceBtn.Size = new System.Drawing.Size(180, 45);
            this.replaceBtn.TabIndex = 2;
            this.replaceBtn.Text = "Редактировать";
            this.replaceBtn.Click += new System.EventHandler(this.replaceBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Никнейм";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // nickNameTB
            // 
            this.nickNameTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nickNameTB.DefaultText = "";
            this.nickNameTB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.nickNameTB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.nickNameTB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nickNameTB.DisabledState.Parent = this.nickNameTB;
            this.nickNameTB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nickNameTB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nickNameTB.FocusedState.Parent = this.nickNameTB;
            this.nickNameTB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nickNameTB.HoverState.Parent = this.nickNameTB;
            this.nickNameTB.Location = new System.Drawing.Point(58, 77);
            this.nickNameTB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nickNameTB.Name = "nickNameTB";
            this.nickNameTB.PasswordChar = '\0';
            this.nickNameTB.PlaceholderText = "";
            this.nickNameTB.ReadOnly = true;
            this.nickNameTB.SelectedText = "";
            this.nickNameTB.ShadowDecoration.Parent = this.nickNameTB;
            this.nickNameTB.Size = new System.Drawing.Size(176, 27);
            this.nickNameTB.TabIndex = 4;
            this.nickNameTB.TextChanged += new System.EventHandler(this.nickNameTB_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Логин";
            // 
            // loginTB
            // 
            this.loginTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.loginTB.DefaultText = "";
            this.loginTB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.loginTB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.loginTB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.loginTB.DisabledState.Parent = this.loginTB;
            this.loginTB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.loginTB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.loginTB.FocusedState.Parent = this.loginTB;
            this.loginTB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.loginTB.HoverState.Parent = this.loginTB;
            this.loginTB.Location = new System.Drawing.Point(58, 143);
            this.loginTB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.loginTB.Name = "loginTB";
            this.loginTB.PasswordChar = '\0';
            this.loginTB.PlaceholderText = "";
            this.loginTB.ReadOnly = true;
            this.loginTB.SelectedText = "";
            this.loginTB.ShadowDecoration.Parent = this.loginTB;
            this.loginTB.Size = new System.Drawing.Size(176, 27);
            this.loginTB.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Пароль";
            // 
            // passwordTB
            // 
            this.passwordTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passwordTB.DefaultText = "";
            this.passwordTB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.passwordTB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.passwordTB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passwordTB.DisabledState.Parent = this.passwordTB;
            this.passwordTB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passwordTB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.passwordTB.FocusedState.Parent = this.passwordTB;
            this.passwordTB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.passwordTB.HoverState.Parent = this.passwordTB;
            this.passwordTB.Location = new System.Drawing.Point(58, 207);
            this.passwordTB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.passwordTB.Name = "passwordTB";
            this.passwordTB.PasswordChar = '\0';
            this.passwordTB.PlaceholderText = "";
            this.passwordTB.ReadOnly = true;
            this.passwordTB.SelectedText = "";
            this.passwordTB.ShadowDecoration.Parent = this.passwordTB;
            this.passwordTB.Size = new System.Drawing.Size(176, 27);
            this.passwordTB.TabIndex = 8;
            // 
            // guna2Button1
            // 
            this.guna2Button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("guna2Button1.BackgroundImage")));
            this.guna2Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.FillColor = System.Drawing.Color.Black;
            this.guna2Button1.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Location = new System.Drawing.Point(13, 13);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(37, 34);
            this.guna2Button1.TabIndex = 9;
            this.guna2Button1.Text = "<-";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // avatarImageBX
            // 
            this.avatarImageBX.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("avatarImageBX.BackgroundImage")));
            this.avatarImageBX.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.avatarImageBX.Location = new System.Drawing.Point(360, 32);
            this.avatarImageBX.Name = "avatarImageBX";
            this.avatarImageBX.Size = new System.Drawing.Size(96, 72);
            this.avatarImageBX.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.avatarImageBX.TabIndex = 10;
            this.avatarImageBX.TabStop = false;
            // 
            // openBtn
            // 
            this.openBtn.CheckedState.Parent = this.openBtn;
            this.openBtn.CustomImages.Parent = this.openBtn;
            this.openBtn.FillColor = System.Drawing.Color.Gray;
            this.openBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.openBtn.ForeColor = System.Drawing.Color.White;
            this.openBtn.HoverState.Parent = this.openBtn;
            this.openBtn.Location = new System.Drawing.Point(370, 112);
            this.openBtn.Name = "openBtn";
            this.openBtn.ShadowDecoration.Parent = this.openBtn;
            this.openBtn.Size = new System.Drawing.Size(73, 27);
            this.openBtn.TabIndex = 11;
            this.openBtn.Text = "Открыть";
            this.openBtn.Click += new System.EventHandler(this.openBtn_Click);
            // 
            // walletLabel
            // 
            this.walletLabel.AutoSize = true;
            this.walletLabel.BackColor = System.Drawing.Color.Transparent;
            this.walletLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.walletLabel.Location = new System.Drawing.Point(324, 186);
            this.walletLabel.Name = "walletLabel";
            this.walletLabel.Size = new System.Drawing.Size(64, 17);
            this.walletLabel.TabIndex = 12;
            this.walletLabel.Text = "Баланс: ";
            // 
            // topUpBtn
            // 
            this.topUpBtn.CheckedState.Parent = this.topUpBtn;
            this.topUpBtn.CustomImages.Parent = this.topUpBtn;
            this.topUpBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.topUpBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.topUpBtn.ForeColor = System.Drawing.Color.White;
            this.topUpBtn.HoverState.Parent = this.topUpBtn;
            this.topUpBtn.Location = new System.Drawing.Point(327, 260);
            this.topUpBtn.Name = "topUpBtn";
            this.topUpBtn.ShadowDecoration.Parent = this.topUpBtn;
            this.topUpBtn.Size = new System.Drawing.Size(158, 38);
            this.topUpBtn.TabIndex = 13;
            this.topUpBtn.Text = "Пополнить";
            this.topUpBtn.Click += new System.EventHandler(this.topUpBtn_Click);
            // 
            // balanceLable
            // 
            this.balanceLable.AutoSize = true;
            this.balanceLable.BackColor = System.Drawing.Color.Transparent;
            this.balanceLable.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.balanceLable.Location = new System.Drawing.Point(395, 185);
            this.balanceLable.Name = "balanceLable";
            this.balanceLable.Size = new System.Drawing.Size(16, 17);
            this.balanceLable.TabIndex = 14;
            this.balanceLable.Text = "0";
            // 
            // addBalanceTB
            // 
            this.addBalanceTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.addBalanceTB.DefaultText = "";
            this.addBalanceTB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.addBalanceTB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.addBalanceTB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.addBalanceTB.DisabledState.Parent = this.addBalanceTB;
            this.addBalanceTB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.addBalanceTB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.addBalanceTB.FocusedState.Parent = this.addBalanceTB;
            this.addBalanceTB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.addBalanceTB.HoverState.Parent = this.addBalanceTB;
            this.addBalanceTB.Location = new System.Drawing.Point(327, 221);
            this.addBalanceTB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addBalanceTB.Name = "addBalanceTB";
            this.addBalanceTB.PasswordChar = '\0';
            this.addBalanceTB.PlaceholderText = "";
            this.addBalanceTB.SelectedText = "";
            this.addBalanceTB.ShadowDecoration.Parent = this.addBalanceTB;
            this.addBalanceTB.Size = new System.Drawing.Size(158, 32);
            this.addBalanceTB.TabIndex = 15;
            this.addBalanceTB.Visible = false;
            // 
            // acceptBtn
            // 
            this.acceptBtn.CheckedState.Parent = this.acceptBtn;
            this.acceptBtn.CustomImages.Parent = this.acceptBtn;
            this.acceptBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.acceptBtn.ForeColor = System.Drawing.Color.White;
            this.acceptBtn.HoverState.Parent = this.acceptBtn;
            this.acceptBtn.Location = new System.Drawing.Point(492, 221);
            this.acceptBtn.Name = "acceptBtn";
            this.acceptBtn.ShadowDecoration.Parent = this.acceptBtn;
            this.acceptBtn.Size = new System.Drawing.Size(41, 32);
            this.acceptBtn.TabIndex = 16;
            this.acceptBtn.Text = " ✔";
            this.acceptBtn.Visible = false;
            this.acceptBtn.Click += new System.EventHandler(this.acceptBtn_Click);
            // 
            // ProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(569, 450);
            this.Controls.Add(this.acceptBtn);
            this.Controls.Add(this.addBalanceTB);
            this.Controls.Add(this.balanceLable);
            this.Controls.Add(this.topUpBtn);
            this.Controls.Add(this.walletLabel);
            this.Controls.Add(this.openBtn);
            this.Controls.Add(this.avatarImageBX);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.passwordTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.loginTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nickNameTB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.replaceBtn);
            this.Controls.Add(this.getInfoLable);
            this.Name = "ProfileForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ProfileForm";
            this.Load += new System.EventHandler(this.ProfileForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.avatarImageBX)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label getInfoLable;
        private Guna.UI2.WinForms.Guna2Button replaceBtn;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox nickNameTB;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox loginTB;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox passwordTB;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.PictureBox avatarImageBX;
        private Guna.UI2.WinForms.Guna2Button openBtn;
        private System.Windows.Forms.Label walletLabel;
        private Guna.UI2.WinForms.Guna2Button topUpBtn;
        private System.Windows.Forms.Label balanceLable;
        private Guna.UI2.WinForms.Guna2TextBox addBalanceTB;
        private Guna.UI2.WinForms.Guna2Button acceptBtn;
    }
}