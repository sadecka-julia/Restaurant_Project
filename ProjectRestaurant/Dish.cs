using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectRestaurant
{
    class Dish
    {
        protected int _dishID;
        public string Name {get; set;}
        protected float _price;
        protected int _amount;
        public Dish(int dishID, string name, float price, int amount)
        {
            _dishID = dishID;
            Name = name;
            _price = price;
            _amount = amount;
        }
    }
}