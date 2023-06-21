using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectRestaurant
{
    class CAddDishToOrderDI : ICommand
    {
        private OrderDineIn _order;
        private Dish _dish;
        private int _amount;
        private EWaiter _waiter;
        public CAddDishToOrderDI(EWaiter waiter, OrderDineIn order, Dish dish, int amount)
        {
            _waiter = waiter;
            _order = order;
            _dish = dish;
            _amount = amount;
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