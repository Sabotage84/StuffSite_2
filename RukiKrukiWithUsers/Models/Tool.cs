using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RukiKrukiWithUsers.Models
{
    public class Tool
    {
        int iD;
        string name;
        string description;
        bool inStock;
        string image;
        double price;


        public string Name { get => name; set => name = value; }
        public string Description { get => description; set => description = value; }
        public double Price { get => price; set => price = value; }
        public string Image { get => image; set => image = value; }
        public bool InStock { get => inStock; set => inStock = value; }
        public int ID { get => iD; set => iD = value; }
    }
}