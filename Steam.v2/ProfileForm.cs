using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using App.Models;

namespace Steam.v2
{
    public partial class ProfileForm : Form
    {
        public ProfileForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void nickNameTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void replaceBtn_Click(object sender, EventArgs e)
        {
            if (replaceBtn.Text == "Редактировать")
            {
                nickNameTB.ReadOnly = false;
                loginTB.ReadOnly = false;
                passwordTB.ReadOnly = false;
                replaceBtn.Text = "Сохранить";
            }
            else 
            {
                SteamClient.ChangeNickName(nickNameTB.Text);
                SteamClient.ChangeLogin(loginTB.Text);
                SteamClient.ChangePassword(passwordTB.Text);
                getInfoLable.Text = SteamClient.CurrentAccount.NickName;
                replaceBtn.Text = "Редактировать";
                nickNameTB.ReadOnly = true;
                loginTB.ReadOnly = true;
                passwordTB.ReadOnly = true;
                SteamClient.dataStorage.Save(SteamClient.accountManager._accounts);
            }
        }

        private void ProfileForm_Load(object sender, EventArgs e)
        {
            nickNameTB.Text = SteamClient.CurrentAccount.NickName;
            loginTB.Text = SteamClient.CurrentAccount.Login;
            passwordTB.Text = SteamClient.CurrentAccount.Password;
            getInfoLable.Text = SteamClient.CurrentAccount.NickName;
            balanceLable.Text = SteamClient.CurrentAccount.wallet.Balance.ToString();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            new MainMenuForm().Show();
            this.Close();
        }

        private void openBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image File(*.BMP; *.JPG; *GIF; *.PNG)| *.BMP; *.JPG; *.GIF; *.PNG | All files (*.*)|*.* ";

            if (open.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    avatarImageBX.Image = new Bitmap(open.FileName);
                }
                catch
                {
                    MessageBox.Show("Невозможно открыть выбранный файл", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void balanceLable_Click(object sender, EventArgs e)
        {
        }

        private void getInfoLable_Click(object sender, EventArgs e)
        {

        }

        private void topUpBtn_Click(object sender, EventArgs e)
        {
            addBalanceTB.Visible = true;
            acceptBtn.Visible = true;
        }

        private void acceptBtn_Click(object sender, EventArgs e)
        {
            decimal addBalance = 0;
            decimal.TryParse(addBalanceTB.Text, out addBalance);
            if (addBalance >= 1)
            {
                SteamClient.CurrentAccount.wallet.Balance += addBalance;
                addBalanceTB.Visible = false;
                acceptBtn.Visible = false;
                addBalanceTB.BorderColor = Color.Green;
                balanceLable.Text = SteamClient.CurrentAccount.wallet.Balance.ToString();
                SteamClient.dataStorage.Save(SteamClient.accountManager._accounts);
            }
            else
            {
                addBalanceTB.BorderColor = Color.Red;
            }
        }
    }
}
