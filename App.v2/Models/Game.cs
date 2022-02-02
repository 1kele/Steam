using System;
using System.Collections.Generic;
using System.Text;

namespace App.Models
{
    public class Game
    {
        private string Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string ImgPath { get; set; }
        public string ExePath { get; set; }

        public Game(string name, decimal price, string imgPath, string exePath)
        {
            Id = Guid.NewGuid().ToString();
            Name = name;
            Price = price;
            ImgPath = imgPath;
            ExePath = exePath;
        }
    }
}
