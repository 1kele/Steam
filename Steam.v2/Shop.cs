using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using App.Models;

namespace Steam.v2
{
    public partial class Shop : Form
    {
        public Shop()
        {
            InitializeComponent();
        }

        private void Shop_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            Shop shop = new Shop();
            FillShop();
        }

        private void FillShop()
        {
            int startX = 70;
            int startY = 80;
            int imageWidth = 70 * 3;
            int imageHeight = 60 * 3;
            int x = startX;
            int y = startY;

            for (int i = 0; i < App.Models.Shop.allGames.Count; i++)
            {
                Label lable = new Label();
                PictureBox box = new PictureBox();
                box.Location = new Point(x, y);
                box.Name = $"gameImage {App.Models.Shop.allGames[i].Name}";
                box.Size = new Size(imageWidth, imageHeight);
                box.Image = Image.FromFile(App.Models.Shop.allGames[i].ImgPath);
                box.SizeMode = PictureBoxSizeMode.StretchImage;
                box.Click += new EventHandler(this.game_click);
                /*
                Label lable = new Label();
                lable.Location = new Point(startX, startY * 2);
                lable.Size = new Size(imageWidth, imageHeight);
                lable.Text = $"{App.Models.Shop.allGames[i].Price}";
                Controls.Add(lable);
                */
                Controls.Add(box);

                if (x + imageWidth + 90 > ClientSize.Width)
                {
                    y += imageHeight + 30;
                    x = startX;
                }
                else
                {
                    x += imageWidth + 30;
                }
            }
        }

        private void game_click(object sender, EventArgs e)
        {
            PictureBox gameBox = (PictureBox)sender;
            string gameName = gameBox.Name.Remove(0, gameBox.Name.IndexOf(" ") + 1);
            Game game = App.Models.Shop.allGames.Where(x => x.Name == gameName).FirstOrDefault();
            new InfoGameForm(game).Show();
            this.Close();
        }

        private void backMainMenuBtn_Click(object sender, EventArgs e)
        {
            new MainMenuForm().Show();
            this.Close();
        }
    }
}
