
namespace Steam.v2
{
    partial class MyGameForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyGameForm));
            this.label1 = new System.Windows.Forms.Label();
            this.BackMainMenuBtn = new Guna.UI2.WinForms.Guna2Button();
            this.deletGameBtn = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(340, 37);
            this.label1.MaximumSize = new System.Drawing.Size(100, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "МОИ ИГРЫ";
            // 
            // BackMainMenuBtn
            // 
            this.BackMainMenuBtn.BackColor = System.Drawing.Color.Black;
            this.BackMainMenuBtn.CheckedState.Parent = this.BackMainMenuBtn;
            this.BackMainMenuBtn.CustomImages.Parent = this.BackMainMenuBtn;
            this.BackMainMenuBtn.FillColor = System.Drawing.Color.White;
            this.BackMainMenuBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BackMainMenuBtn.ForeColor = System.Drawing.Color.Black;
            this.BackMainMenuBtn.HoverState.Parent = this.BackMainMenuBtn;
            this.BackMainMenuBtn.Location = new System.Drawing.Point(41, 37);
            this.BackMainMenuBtn.Name = "BackMainMenuBtn";
            this.BackMainMenuBtn.ShadowDecoration.Parent = this.BackMainMenuBtn;
            this.BackMainMenuBtn.Size = new System.Drawing.Size(54, 45);
            this.BackMainMenuBtn.TabIndex = 1;
            this.BackMainMenuBtn.Text = "<";
            this.BackMainMenuBtn.Click += new System.EventHandler(this.BackMainMenuBtn_Click);
            // 
            // deletGameBtn
            // 
            this.deletGameBtn.CheckedState.Parent = this.deletGameBtn;
            this.deletGameBtn.CustomImages.Parent = this.deletGameBtn;
            this.deletGameBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.deletGameBtn.ForeColor = System.Drawing.Color.White;
            this.deletGameBtn.HoverState.Parent = this.deletGameBtn;
            this.deletGameBtn.Location = new System.Drawing.Point(589, 37);
            this.deletGameBtn.Name = "deletGameBtn";
            this.deletGameBtn.ShadowDecoration.Parent = this.deletGameBtn;
            this.deletGameBtn.Size = new System.Drawing.Size(180, 45);
            this.deletGameBtn.TabIndex = 2;
            this.deletGameBtn.Text = "Удалить игру";
            this.deletGameBtn.Click += new System.EventHandler(this.deletGameBtn_Click);
            // 
            // MyGameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.deletGameBtn);
            this.Controls.Add(this.BackMainMenuBtn);
            this.Controls.Add(this.label1);
            this.Name = "MyGameForm";
            this.Text = "MyGameForm";
            this.Load += new System.EventHandler(this.MyGameForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button BackMainMenuBtn;
        private Guna.UI2.WinForms.Guna2Button deletGameBtn;
    }
}