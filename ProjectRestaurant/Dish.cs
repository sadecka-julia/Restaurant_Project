using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectRestaurant
{
    class Dish
    {
        private int _dishID;
        private string _name;
        private float _price;
        private int _amount;
        public Dish(int dishID, string name, float price, int amount)
        {
            _dishID = dishID;
            _name = name;
            _price = price;
            _amount = amount;
        }

    }
}