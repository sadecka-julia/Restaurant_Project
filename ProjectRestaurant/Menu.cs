using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectRestaurant
{
    class Menu
    {
        public List<Dish> dishes = new List<Dish>();
        public List<Beverage> beverages = new List<Beverage>();
        public void AddDish(Dish dish)
        {
            dishes.Add(dish);
        }
        public void AddBeverage(Beverage beverage)
        {
            beverages.Add(beverage);
        }

    }
    
}