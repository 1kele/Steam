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
        public double Hours { get; set; }

        public Game(string name, decimal price)
        {
            Id = Guid.NewGuid().ToString();
            Name = name;
            Price = price;
            Hours = 0;
        }
    }
}
