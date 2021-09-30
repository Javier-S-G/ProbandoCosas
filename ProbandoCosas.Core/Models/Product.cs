using System;
using System.Collections.Generic;
using System.Text;

namespace ProbandoCosas.Core.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Amount { get; set; }

        public Product(int id, string name, decimal price, int amount)
        {
            Id = id;
            Name = name;
            Price = price;
            Amount = amount;
        }
    }
}