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
            allGames.Add(new Game("Dota 2", 199));
            allGames.Add(new Game("CS:GO", 1199));
            allGames.Add(new Game("Fortnite", 142));
        }
        public static Game FindGameByNam(string gameName)
        {
            Game game = allGames.FirstOrDefault(x => x.Name == gameName);
            return game;
        }
    }
}
