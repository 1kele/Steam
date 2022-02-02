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
            return _accounts.Where(x => x.Login == login).FirstOrDefault() != null;
        }
        public bool CheckAccount(string login, string password)
        {
            return _accounts.Where(x => x.Login == login && x.Password == password).FirstOrDefault() != null;
        }

        public Account Autorization(string login, string password)
        {
            Account currentAccount = _accounts.FirstOrDefault(x => x.Login == login && x.Password == password);//cdec
            return currentAccount;
        }
    }
}
