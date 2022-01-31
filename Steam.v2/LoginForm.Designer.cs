
namespace Steam.v2
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.enterBtn = new Guna.UI2.WinForms.Guna2Button();
            this.loginTB = new Guna.UI2.WinForms.Guna2TextBox();
            this.passwordTB = new Guna.UI2.WinForms.Guna2TextBox();
            this.registrationLable = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // enterBtn
            // 
            this.enterBtn.CheckedState.Parent = this.enterBtn;
            this.enterBtn.CustomImages.Parent = this.enterBtn;
            this.enterBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.enterBtn.ForeColor = System.Drawing.Color.White;
            this.enterBtn.HoverState.Parent = this.enterBtn;
            this.enterBtn.Location = new System.Drawing.Point(99, 241);
            this.enterBtn.Name = "enterBtn";
            this.enterBtn.ShadowDecoration.Parent = this.enterBtn;
            this.enterBtn.Size = new System.Drawing.Size(180, 45);
            this.enterBtn.TabIndex = 0;
            this.enterBtn.Text = "Вход";
            this.enterBtn.Click += new System.EventHandler(this.enterBtn_Click);
            // 
            // loginTB
            // 
            this.loginTB.BackColor = System.Drawing.Color.Transparent;
            this.loginTB.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("loginTB.BackgroundImage")));
            this.loginTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.loginTB.DefaultText = "";
            this.loginTB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.loginTB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.loginTB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.loginTB.DisabledState.Parent = this.loginTB;
            this.loginTB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.loginTB.FillColor = System.Drawing.Color.WhiteSmoke;
            this.loginTB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.loginTB.FocusedState.Parent = this.loginTB;
            this.loginTB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.loginTB.HoverState.Parent = this.loginTB;
            this.loginTB.Location = new System.Drawing.Point(76, 121);
            this.loginTB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.loginTB.Name = "loginTB";
            this.loginTB.PasswordChar = '\0';
            this.loginTB.PlaceholderText = "Логин";
            this.loginTB.SelectedText = "";
            this.loginTB.ShadowDecoration.Parent = this.loginTB;
            this.loginTB.Size = new System.Drawing.Size(237, 27);
            this.loginTB.TabIndex = 1;
            // 
            // passwordTB
            // 
            this.passwordTB.BackColor = System.Drawing.Color.Transparent;
            this.passwordTB.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("passwordTB.BackgroundImage")));
            this.passwordTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passwordTB.DefaultText = "";
            this.passwordTB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.passwordTB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.passwordTB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passwordTB.DisabledState.Parent = this.passwordTB;
            this.passwordTB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passwordTB.FillColor = System.Drawing.Color.WhiteSmoke;
            this.passwordTB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.passwordTB.FocusedState.Parent = this.passwordTB;
            this.passwordTB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.passwordTB.HoverState.Parent = this.passwordTB;
            this.passwordTB.Location = new System.Drawing.Point(76, 182);
            this.passwordTB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.passwordTB.Name = "passwordTB";
            this.passwordTB.PasswordChar = '*';
            this.passwordTB.PlaceholderText = "Пароль";
            this.passwordTB.SelectedText = "";
            this.passwordTB.ShadowDecoration.Parent = this.passwordTB;
            this.passwordTB.Size = new System.Drawing.Size(237, 27);
            this.passwordTB.TabIndex = 2;
            // 
            // registrationLable
            // 
            this.registrationLable.AutoSize = true;
            this.registrationLable.BackColor = System.Drawing.Color.Transparent;
            this.registrationLable.Location = new System.Drawing.Point(104, 320);
            this.registrationLable.Name = "registrationLable";
            this.registrationLable.Size = new System.Drawing.Size(175, 17);
            this.registrationLable.TabIndex = 3;
            this.registrationLable.Text = "Хотите завести аккаунт?";
            this.registrationLable.Click += new System.EventHandler(this.registrationLable_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(104, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(124, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "АВТОРИЗАЦИЯ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(384, 389);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.registrationLable);
            this.Controls.Add(this.passwordTB);
            this.Controls.Add(this.loginTB);
            this.Controls.Add(this.enterBtn);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button enterBtn;
        private Guna.UI2.WinForms.Guna2TextBox loginTB;
        private Guna.UI2.WinForms.Guna2TextBox passwordTB;
        private System.Windows.Forms.Label registrationLable;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}