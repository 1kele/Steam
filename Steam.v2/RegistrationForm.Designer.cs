
namespace Steam.v2
{
    partial class RegistrationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrationForm));
            this.regBtn = new Guna.UI2.WinForms.Guna2Button();
            this.nameTB = new Guna.UI2.WinForms.Guna2TextBox();
            this.regPasswordTB = new Guna.UI2.WinForms.Guna2TextBox();
            this.regLoginTB = new Guna.UI2.WinForms.Guna2TextBox();
            this.SuspendLayout();
            // 
            // regBtn
            // 
            this.regBtn.CheckedState.Parent = this.regBtn;
            this.regBtn.CustomImages.Parent = this.regBtn;
            this.regBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.regBtn.ForeColor = System.Drawing.Color.White;
            this.regBtn.HoverState.Parent = this.regBtn;
            this.regBtn.Location = new System.Drawing.Point(80, 282);
            this.regBtn.Name = "regBtn";
            this.regBtn.ShadowDecoration.Parent = this.regBtn;
            this.regBtn.Size = new System.Drawing.Size(180, 45);
            this.regBtn.TabIndex = 0;
            this.regBtn.Text = "Зарегистрироваться";
            this.regBtn.Click += new System.EventHandler(this.regBtn_Click);
            // 
            // nameTB
            // 
            this.nameTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nameTB.DefaultText = "";
            this.nameTB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.nameTB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.nameTB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nameTB.DisabledState.Parent = this.nameTB;
            this.nameTB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nameTB.FillColor = System.Drawing.Color.WhiteSmoke;
            this.nameTB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nameTB.FocusedState.Parent = this.nameTB;
            this.nameTB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nameTB.HoverState.Parent = this.nameTB;
            this.nameTB.Location = new System.Drawing.Point(80, 102);
            this.nameTB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nameTB.Name = "nameTB";
            this.nameTB.PasswordChar = '\0';
            this.nameTB.PlaceholderText = "Имя";
            this.nameTB.SelectedText = "";
            this.nameTB.ShadowDecoration.Parent = this.nameTB;
            this.nameTB.Size = new System.Drawing.Size(192, 24);
            this.nameTB.TabIndex = 1;
            // 
            // regPasswordTB
            // 
            this.regPasswordTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.regPasswordTB.DefaultText = "";
            this.regPasswordTB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.regPasswordTB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.regPasswordTB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.regPasswordTB.DisabledState.Parent = this.regPasswordTB;
            this.regPasswordTB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.regPasswordTB.FillColor = System.Drawing.Color.WhiteSmoke;
            this.regPasswordTB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.regPasswordTB.FocusedState.Parent = this.regPasswordTB;
            this.regPasswordTB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.regPasswordTB.HoverState.Parent = this.regPasswordTB;
            this.regPasswordTB.Location = new System.Drawing.Point(77, 213);
            this.regPasswordTB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.regPasswordTB.Name = "regPasswordTB";
            this.regPasswordTB.PasswordChar = '*';
            this.regPasswordTB.PlaceholderText = "Пароль";
            this.regPasswordTB.SelectedText = "";
            this.regPasswordTB.ShadowDecoration.Parent = this.regPasswordTB;
            this.regPasswordTB.Size = new System.Drawing.Size(192, 24);
            this.regPasswordTB.TabIndex = 2;
            // 
            // regLoginTB
            // 
            this.regLoginTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.regLoginTB.DefaultText = "";
            this.regLoginTB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.regLoginTB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.regLoginTB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.regLoginTB.DisabledState.Parent = this.regLoginTB;
            this.regLoginTB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.regLoginTB.FillColor = System.Drawing.Color.WhiteSmoke;
            this.regLoginTB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.regLoginTB.FocusedState.Parent = this.regLoginTB;
            this.regLoginTB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.regLoginTB.HoverState.Parent = this.regLoginTB;
            this.regLoginTB.Location = new System.Drawing.Point(77, 158);
            this.regLoginTB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.regLoginTB.Name = "regLoginTB";
            this.regLoginTB.PasswordChar = '\0';
            this.regLoginTB.PlaceholderText = "Логин";
            this.regLoginTB.SelectedText = "";
            this.regLoginTB.ShadowDecoration.Parent = this.regLoginTB;
            this.regLoginTB.Size = new System.Drawing.Size(192, 24);
            this.regLoginTB.TabIndex = 3;
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(346, 383);
            this.Controls.Add(this.regLoginTB);
            this.Controls.Add(this.regPasswordTB);
            this.Controls.Add(this.nameTB);
            this.Controls.Add(this.regBtn);
            this.Name = "RegistrationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegistrationForm";
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button regBtn;
        private Guna.UI2.WinForms.Guna2TextBox nameTB;
        private Guna.UI2.WinForms.Guna2TextBox regPasswordTB;
        private Guna.UI2.WinForms.Guna2TextBox regLoginTB;
    }
}