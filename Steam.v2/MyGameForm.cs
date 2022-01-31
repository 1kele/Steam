using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using App.Models;

namespace Steam.v2
{
    public partial class MyGameForm : Form
    {
        List<PictureBox> pictureBoxes = new List<PictureBox>();

        bool isDeletBtnActive;
        public MyGameForm()
        {
            InitializeComponent();
        }

        private void MyGameForm_Load(object sender, EventArgs e)
        {
            LoadPicturec();
        }

        private void game_click(object sender, EventArgs e)
        {
            PictureBox gameBox = (PictureBox)sender;
            Game game = App.Models.Shop.allGames.Where(x => x.Name == gameBox.Name).FirstOrDefault();
            if (isDeletBtnActive == false)
            {
                Process.Start(game.ExePath);
            }
            else
            {
                SteamClient.CurrentAccount.DeleteGame(SteamClient.CurrentAccount.games.Where(x => x.Name == gameBox.Name).FirstOrDefault());
                Refresh();
                SteamClient.dataStorage.Save(SteamClient.CurrentAccount.games);
            }
            
        }

        private void BackMainMenuBtn_Click(object sender, EventArgs e)
        {
            new MainMenuForm().Show();
            this.Close();
        }

        private void deletGameBtn_Click(object sender, EventArgs e)
        {
            isDeletBtnActive = (isDeletBtnActive == true)? false : true;

        }

        private void delet_game(object sender, EventArgs e)
        {
            
        }
        public void Refresh()
        {
            foreach (PictureBox box in pictureBoxes)
            {
                box.Dispose();
            }
            LoadPicturec();
        }

        public void LoadPicturec()
        {
            int startX = 70;
            int startY = 80;
            int imageWidth = 70 * 3;
            int imageHeight = 60 * 3;
            int x = startX;
            int y = startY;
            for (int i = 0; i < SteamClient.CurrentAccount.games.Count; i++)
            {
                PictureBox box = new PictureBox();
                box.Location = new Point(x, y);
                box.Name = $"{SteamClient.CurrentAccount.games[i].Name}";
                box.Size = new Size(imageWidth, imageHeight);
                box.Image = Image.FromFile(SteamClient.CurrentAccount.games[i].ImgPath);
                box.SizeMode = PictureBoxSizeMode.StretchImage;
                box.Click += new EventHandler(this.game_click);
                Controls.Add(box);
                pictureBoxes.Add(box);

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
    }
}
