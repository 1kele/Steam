using System;
using System.Collections.Generic;
using System.Text;

namespace App.Models
{
    public static class SteamClient
    {
        public static Account CurrentAccount { get; set; }

        public static AccountManager accountManager = new AccountManager();


        public static void ChangeLogin(string newLogin)
        {
            accountManager.ChangeLogin(CurrentAccount.Login, newLogin);
            CurrentAccount.Login = newLogin;
        }
        public static void ChangePassword(string newPassword)
        {
            accountManager.ChangePassword(CurrentAccount.Password, newPassword);
            CurrentAccount.Password = newPassword;
        }
        public static void ChangeNickName(string newNickName)
        {
            accountManager.ChangeNickName(CurrentAccount.NickName, newNickName);
            CurrentAccount.NickName = newNickName;
        }
    }
}
