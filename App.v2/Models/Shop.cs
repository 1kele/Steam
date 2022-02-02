using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace App.Models
{
    public static class Shop
    {
        public static List<Game> allGames = new List<Game>();

        static Shop()
        {
            SteamClient.dataStorage.Load(out allGames);
        }
        public static Game FindGameByName(string gameName)
        {
            Game game = allGames.FirstOrDefault(x => x.Name == gameName);
            return game;
        }
    }
}
