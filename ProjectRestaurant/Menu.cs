using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectRestaurant
{
    class Menu
    {
        private List<Dish> _dishes = new List<Dish>();
        private List<Beverage> _beverages = new List<Beverage>();
        public void AddDish(Dish dish)
        {
            _dishes.Add(dish);
        }
        public void AddBeverage(Beverage beverage)
        {
            _beverages.Add(beverage);
        }

    }
    
}