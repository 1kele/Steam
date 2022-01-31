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
    public partial class InfoGameForm : Form
    {
        Game CurrentGame { get; set; }
        public InfoGameForm(Game game)
        {
            CurrentGame = game;
            InitializeComponent();
        }

        private void InfoGameForm_Load(object sender, EventArgs e)
        {
            gameNameLable.Text = CurrentGame.Name;
            priceLable.Text = CurrentGame.Price.ToString();
            ImgGamePB.Image = Image.FromFile(CurrentGame.ImgPath);
            balanceLable.Text = SteamClient.CurrentAccount.wallet.Balance.ToString();
            ImgGamePB.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            new Shop().Show();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (SteamClient.CurrentAccount.wallet.Balance >= CurrentGame.Price)
            { 
                if (SteamClient.CurrentAccount.games.Where(x => x.Name == CurrentGame.Name).FirstOrDefault() != null)
                {
                    MessageBox.Show("У вас уже есть эта игра");
                    return;
                }
                SteamClient.CurrentAccount.AddGame(CurrentGame);
                SteamClient.CurrentAccount.wallet.Balance -= CurrentGame.Price;
                balanceLable.Text = SteamClient.CurrentAccount.wallet.Balance.ToString();
                SteamClient.dataStorage.Save(SteamClient.accountManager._accounts);
            }
            else
            {
                MessageBox.Show("Недостаточно средств");
            }
        }
    }
}
