
namespace Steam.v2
{
    partial class Shop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Shop));
            this.backMainMenuBtn = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // backMainMenuBtn
            // 
            this.backMainMenuBtn.CheckedState.Parent = this.backMainMenuBtn;
            this.backMainMenuBtn.CustomImages.Parent = this.backMainMenuBtn;
            this.backMainMenuBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.backMainMenuBtn.ForeColor = System.Drawing.Color.White;
            this.backMainMenuBtn.HoverState.Parent = this.backMainMenuBtn;
            this.backMainMenuBtn.Location = new System.Drawing.Point(37, 30);
            this.backMainMenuBtn.Name = "backMainMenuBtn";
            this.backMainMenuBtn.ShadowDecoration.Parent = this.backMainMenuBtn;
            this.backMainMenuBtn.Size = new System.Drawing.Size(66, 45);
            this.backMainMenuBtn.TabIndex = 0;
            this.backMainMenuBtn.Text = "<";
            this.backMainMenuBtn.Click += new System.EventHandler(this.backMainMenuBtn_Click);
            // 
            // Shop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1222, 450);
            this.Controls.Add(this.backMainMenuBtn);
            this.Name = "Shop";
            this.Text = "Shop";
            this.Load += new System.EventHandler(this.Shop_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button backMainMenuBtn;
    }
}