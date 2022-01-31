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
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void regBtn_Click(object sender, EventArgs e)
        {
            string regLogin = regLoginTB.Text;
            string regPassword = regPasswordTB.Text;
            string regNickName = nameTB.Text;

            if (SteamClient.accountManager.CheckLogin(regLogin))
            {
                MessageBox.Show("Аккаунт с таким логином уже существует");
            }
            else
            {
                if (regLoginTB.Text == "")
                {
                    MessageBox.Show("Введите логин");
                }
                if (regPasswordTB.Text == "")
                {
                    MessageBox.Show("Введите пароль");
                }
                if (nameTB.Text == "")
                {
                    MessageBox.Show("Введите Никнейм");
                }
                if (regLoginTB.Text != "" && regPasswordTB.Text != "" && nameTB.Text != "")
                {
                    SteamClient.accountManager.CreateAccount(regLogin, regPassword, regNickName);
                    MessageBox.Show("Вы успешно зарегистрировали аккаунт");
                    SteamClient.dataStorage.Save(SteamClient.accountManager._accounts);
                    this.Close();
                }
            }
        }
    }
}
