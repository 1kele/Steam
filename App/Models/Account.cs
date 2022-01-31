using System;
using System.Collections.Generic;
using System.Text;

namespace App.Models
{
    public class Account
    {
        private string Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string NickName { get; set; }

        private decimal balance;

        public decimal Balance
        {
            get { return balance; }
            set 
            { 
                if (value < 0)
                {
                    balance = 0;
                }
                balance = value;
            }
        }


        public List<Game> games = new List<Game>();
        public string getInfo()
        {
            return $" Ник: {NickName}\n Баланс: {Balance}\n Логин: {Login}\n Пароль: {Password}";
        }

        public void CreateAccount(string login, string password,string nickName)
        {
            Login = login;
            Password = password;
            NickName = nickName;
            Id = Guid.NewGuid().ToString();
        }

        public void AddGame(Game game)
        {
            if (game != null)
            {
                games.Add(game);
            }
            else
            {
                return;
            }
        }

        public void DeleteGame(Game game)
        {
            if (game != null)
            {
                games.Remove(game);
            }
            else
            {
                return;
            }
        }
    }
}
