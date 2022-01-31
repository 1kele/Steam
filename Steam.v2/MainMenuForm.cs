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
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();
        }

        private void getInfoLable_MouseHover(object sender, EventArgs e)
        {
            getInfoLable.Font = new Font("Arial", 10, FontStyle.Bold);
        }

        private void getInfoLable_MouseLeave(object sender, EventArgs e)
        {
            getInfoLable.Font = new Font("Arial", 8, FontStyle.Bold);
        }

        private void mainMenuLoad(object sender, EventArgs e)
        {
            getInfoLable.Text = SteamClient.CurrentAccount.NickName;
        }

        private void getInfoLable_Click(object sender, EventArgs e)
        {
            new ProfileForm().Show();
            this.Close();
        }

        private void ShopOpenLable_Click(object sender, EventArgs e)
        {
            new Shop().Show();
            this.Close();
        }

        private void myGameLable_Click(object sender, EventArgs e)
        {
            new MyGameForm().Show();
            this.Close();
        }
    }
}
