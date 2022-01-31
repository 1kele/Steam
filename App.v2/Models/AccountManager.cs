using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace App.Models
{
    public class AccountManager
    {
        public List<Account> _accounts = new List<Account>();
        public Account CreateAccount(string login, string password, string nickName)
        {
            Account newAcc = new Account();

            newAcc.CreateAccount(login,password,nickName);
            _accounts.Add(newAcc);

            return newAcc;
        }
        public bool CheckLogin(string login)
        {
            List<Account> accounts = _accounts.Where(x => x.Login == login).ToList();
            if (accounts.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool CheckAccount(string login, string password)
        {
            List<Account> accounts = _accounts.Where(x => x.Login == login && x.Password == password).ToList();
            if (accounts.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool ReplaceLogin(string lLogin, object login)
        {
            throw new NotImplementedException();
        }

        public Account AutoResation(string login, string password)
        {
            Account currentAccount = _accounts.FirstOrDefault(x => x.Login == login && x.Password == password);//cdec
            return currentAccount;
        }

        public bool ReplacePassword(string password, string pPasword)
        {
            if (pPasword != password)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public Account Login(string login ,string password)
        {
            Account account = _accounts.FirstOrDefault(x => x.Login == login && x.Password == password);
            return account;
        }

        public void ChangeLogin(string login, string newLogin)
        {
            _accounts.FirstOrDefault(x => x.Login == login).Login = newLogin;
        }
        public void ChangePassword(string password, string newPassword)
        {
            _accounts.FirstOrDefault(x => x.Password == password).Password = newPassword;
        }
        public void ChangeNickName(string nickName, string newNickName)
        {
            _accounts.FirstOrDefault(x => x.NickName == nickName).NickName = newNickName;
        }
    }
}
