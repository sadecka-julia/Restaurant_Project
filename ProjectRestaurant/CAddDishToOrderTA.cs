using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectRestaurant
{
    class CAddDishToOrderTA : ICommand
    {
        private OrderTakeAway _order;
        private Dish _dish;
        private int _amount;
        public CAddDishToOrderTA(OrderTakeAway order, Dish dish, int amount)
        {
            _amount = amount;
            _order = order;
            _dish = dish;
        }
        public void Execute()
        {
            if (_dish.Amount > 0)
            {
                for(int i=0; i<_amount; i++)
                {
                    _order.AddDish(_dish);
                }
            }
            else
            {
                Console.WriteLine($"This product {_dish.name} is unavailable");
            }
        }
    }
}