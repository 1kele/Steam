using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.Models;
using Newtonsoft.Json;

namespace App.v2.Models
{
    public class DataStorage
    {
        private string _pathToStorage;

        private string _accountsFile = "Account.txt";
        private string _gamesFile = "Games.txt";

        public DataStorage(string pathToStorage)
        {
            _pathToStorage = pathToStorage;

            if (!Directory.Exists(_pathToStorage))
            {
                Directory.CreateDirectory(pathToStorage);
            }
        }

        public void Save(List<Account> accounts, List<Game> games)
        {
            Save(accounts);
            Save(games);
        }

        public void Save(List<Account> accounts)
        {
            using (StreamWriter sw = new StreamWriter(Path.Combine(_pathToStorage, _accountsFile)))
            {
                sw.WriteLine(JsonConvert.SerializeObject(accounts));
            }
        }

        public void Save(List<Game> games)
        {
            using (StreamWriter sw = new StreamWriter(Path.Combine(_pathToStorage, _gamesFile)))
            {
                sw.WriteLine(JsonConvert.SerializeObject(games));
            }
        }


        public void Load(out List<Account> accounts)
        {
            using (StreamReader sr = new StreamReader(Path.Combine(_pathToStorage, _accountsFile)))
            {
                accounts = JsonConvert.DeserializeObject<List<Account>>(sr.ReadToEnd());

                if (accounts == null)
                {
                    accounts = new List<Account>();
                }
            }
        }
        public void Load(out List<Game> games)
        {
            using (StreamReader sr = new StreamReader(Path.Combine(_pathToStorage, _gamesFile)))
            {
                games = JsonConvert.DeserializeObject<List<Game>>(sr.ReadToEnd());

                if (games == null)
                {
                    games = new List<Game>();

                    games.Add(new Game("Dota 2", 199, @"C:\Users\Мария\source\repos\Steam.v2\Steam.v2\gameImges\DOTA.jpg", @"C:\Program Files (x86)\Steam\steamapps\common\dota 2 beta\game\bin\win64\dota2.exe"));
                    games.Add(new Game("CS:GO", 1199, @"C:\Users\Мария\source\repos\Steam.v2\Steam.v2\gameImges\CSGO.jpg", @"C:\Program Files (x86)\Steam\steamapps\common\dota 2 beta\game\bin\win64\dota2.exe"));
                    games.Add(new Game("Fortnite", 142, @"C:\Users\Мария\source\repos\Steam.v2\Steam.v2\gameImges\Fortnite.jpg", @"C:\Program Files (x86)\Steam\steamapps\common\dota 2 beta\game\bin\win64\dota2.exe"));
                    games.Add(new Game("Minecraft", 999, @"C:\Users\Мария\source\repos\Steam.v2\Steam.v2\gameImges\Mine.jpg", @"C:\Program Files (x86)\Steam\steamapps\common\dota 2 beta\game\bin\win64\dota2.exe"));
                    games.Add(new Game("Apex Legends", 2400, @"C:\Users\Мария\source\repos\Steam.v2\Steam.v2\gameImges\Apex.jpg", @"C:\Program Files (x86)\Steam\steamapps\common\dota 2 beta\game\bin\win64\dota2.exe"));
                    games.Add(new Game("GTA 5", 1900, @"C:\Users\Мария\source\repos\Steam.v2\Steam.v2\gameImges\GRA 5.jpg", @"C:\Program Files (x86)\Steam\steamapps\common\dota 2 beta\game\bin\win64\dota2.exe"));
                    games.Add(new Game("Need For Speed", 5000, @"C:\Users\Мария\source\repos\Steam.v2\Steam.v2\gameImges\NFS.jpg", @"C:\Program Files (x86)\Steam\steamapps\common\dota 2 beta\game\bin\win64\dota2.exe"));
                    games.Add(new Game("Geometry Dash", 10000, @"C:\Users\Мария\source\repos\Steam.v2\Steam.v2\gameImges\GD.png", @"C:\Program Files (x86)\Steam\steamapps\common\dota 2 beta\game\bin\win64\dota2.exe"));
                }
            }
            Save(games);
        }
    }
}
