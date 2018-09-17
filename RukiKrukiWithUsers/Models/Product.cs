using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RukiKrukiWithUsers.Models
{
    public class Product
    {
        string name;

        int iD;

        string image;

        string description;

        double price;

        bool isInStock;

        public string Name { get => name; set => name = value; }
        public string Description { get => description; set => description = value; }
        public double Price { get => price; set => price = value; }
        public bool IsInStock { get => isInStock; set => isInStock = value; }
        public string Image { get => image; set => image = value; }
        public int ID { get => iD; set => iD = value; }


    }
}