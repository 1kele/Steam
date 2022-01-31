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

        public Wallet wallet = new Wallet();

        public List<Game> games = new List<Game>();
        public string getInfo()
        {
            return $" Ник: {NickName}\n Баланс: {wallet.Balance}\n Логин: {Login}\n Пароль: {Password}";
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
