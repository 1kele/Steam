
namespace Steam.v2
{
    partial class InfoGameForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InfoGameForm));
            this.ImgGamePB = new System.Windows.Forms.PictureBox();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.priceLable = new System.Windows.Forms.Label();
            this.gameNameLable = new System.Windows.Forms.Label();
            this.balanceLable = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ImgGamePB)).BeginInit();
            this.SuspendLayout();
            // 
            // ImgGamePB
            // 
            this.ImgGamePB.Location = new System.Drawing.Point(246, 28);
            this.ImgGamePB.Name = "ImgGamePB";
            this.ImgGamePB.Size = new System.Drawing.Size(280, 149);
            this.ImgGamePB.TabIndex = 0;
            this.ImgGamePB.TabStop = false;
            // 
            // guna2Button1
            // 
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Location = new System.Drawing.Point(520, 282);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(180, 45);
            this.guna2Button1.TabIndex = 1;
            this.guna2Button1.Text = "Купить";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // priceLable
            // 
            this.priceLable.AutoSize = true;
            this.priceLable.BackColor = System.Drawing.Color.Transparent;
            this.priceLable.ForeColor = System.Drawing.Color.White;
            this.priceLable.Location = new System.Drawing.Point(605, 243);
            this.priceLable.Name = "priceLable";
            this.priceLable.Size = new System.Drawing.Size(46, 17);
            this.priceLable.TabIndex = 2;
            this.priceLable.Text = "label1";
            // 
            // gameNameLable
            // 
            this.gameNameLable.AutoSize = true;
            this.gameNameLable.BackColor = System.Drawing.Color.Transparent;
            this.gameNameLable.ForeColor = System.Drawing.Color.White;
            this.gameNameLable.Location = new System.Drawing.Point(354, 207);
            this.gameNameLable.Name = "gameNameLable";
            this.gameNameLable.Size = new System.Drawing.Size(46, 17);
            this.gameNameLable.TabIndex = 3;
            this.gameNameLable.Text = "label2";
            // 
            // balanceLable
            // 
            this.balanceLable.AutoSize = true;
            this.balanceLable.BackColor = System.Drawing.Color.Transparent;
            this.balanceLable.ForeColor = System.Drawing.Color.White;
            this.balanceLable.Location = new System.Drawing.Point(707, 38);
            this.balanceLable.Name = "balanceLable";
            this.balanceLable.Size = new System.Drawing.Size(46, 17);
            this.balanceLable.TabIndex = 4;
            this.balanceLable.Text = "label1";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.ForeColor = System.Drawing.Color.Blue;
            this.button1.Location = new System.Drawing.Point(23, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(49, 43);
            this.button1.TabIndex = 5;
            this.button1.Text = "<";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(517, 243);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Стоимость:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(635, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Баланс:";
            // 
            // InfoGameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.balanceLable);
            this.Controls.Add(this.gameNameLable);
            this.Controls.Add(this.priceLable);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.ImgGamePB);
            this.Name = "InfoGameForm";
            this.Text = "InfoGameForm";
            this.Load += new System.EventHandler(this.InfoGameForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ImgGamePB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ImgGamePB;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.Label priceLable;
        private System.Windows.Forms.Label gameNameLable;
        private System.Windows.Forms.Label balanceLable;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}