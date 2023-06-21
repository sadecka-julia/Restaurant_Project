using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectRestaurant
{
    class Dish
    {
        protected int _dishID;
        public string name {get; set;}
        public float price {get; set;}
        public int Amount {get; set;}
        public Dish(int dishID, string name, float price, int amount)
        {
            _dishID = dishID;
            this.name = name;
            this.price = price;
            Amount = amount;
        }
    }
}