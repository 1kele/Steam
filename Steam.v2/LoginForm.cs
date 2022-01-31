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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            SteamClient.dataStorage.Load(out SteamClient.accountManager._accounts);
        }

        private void enterBtn_Click(object sender, EventArgs e)
        {
            MainMenuForm mainMenu = new MainMenuForm();
            string login = loginTB.Text;
            string password = passwordTB.Text;
            if (SteamClient.accountManager.CheckAccount(login, password))
            {
                SteamClient.CurrentAccount = SteamClient.accountManager.AutoResation(login, password);
                MessageBox.Show("Вы вошли в свой Аккаунт");
                mainMenu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Такого аккаунта не существует");
            }

        }

        private void registrationLable_Click(object sender, EventArgs e)
        {
            RegistrationForm registration = new RegistrationForm();
            registration.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
