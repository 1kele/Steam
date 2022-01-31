
namespace Steam.v2
{
    partial class MainMenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenuForm));
            this.getInfoLable = new System.Windows.Forms.Label();
            this.ShopOpenLable = new System.Windows.Forms.Label();
            this.myGameLable = new System.Windows.Forms.Label();
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
            this.getInfoLable.TabIndex = 0;
            this.getInfoLable.Text = "Информация ";
            this.getInfoLable.UseCompatibleTextRendering = true;
            this.getInfoLable.Click += new System.EventHandler(this.getInfoLable_Click);
            this.getInfoLable.MouseLeave += new System.EventHandler(this.getInfoLable_MouseLeave);
            this.getInfoLable.MouseHover += new System.EventHandler(this.getInfoLable_MouseHover);
            // 
            // ShopOpenLable
            // 
            this.ShopOpenLable.AutoSize = true;
            this.ShopOpenLable.BackColor = System.Drawing.Color.Transparent;
            this.ShopOpenLable.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ShopOpenLable.Location = new System.Drawing.Point(89, 89);
            this.ShopOpenLable.Name = "ShopOpenLable";
            this.ShopOpenLable.Size = new System.Drawing.Size(74, 17);
            this.ShopOpenLable.TabIndex = 1;
            this.ShopOpenLable.Text = "МАГАЗИН";
            this.ShopOpenLable.Click += new System.EventHandler(this.ShopOpenLable_Click);
            // 
            // myGameLable
            // 
            this.myGameLable.AutoSize = true;
            this.myGameLable.BackColor = System.Drawing.Color.Transparent;
            this.myGameLable.ForeColor = System.Drawing.Color.White;
            this.myGameLable.Location = new System.Drawing.Point(92, 141);
            this.myGameLable.Name = "myGameLable";
            this.myGameLable.Size = new System.Drawing.Size(72, 17);
            this.myGameLable.TabIndex = 2;
            this.myGameLable.Text = "Мои Игры";
            this.myGameLable.Click += new System.EventHandler(this.myGameLable_Click);
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(569, 450);
            this.Controls.Add(this.myGameLable);
            this.Controls.Add(this.ShopOpenLable);
            this.Controls.Add(this.getInfoLable);
            this.Name = "MainMenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainMenuForm";
            this.Load += new System.EventHandler(this.mainMenuLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label getInfoLable;
        private System.Windows.Forms.Label ShopOpenLable;
        private System.Windows.Forms.Label myGameLable;
    }
}