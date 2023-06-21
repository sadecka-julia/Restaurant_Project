using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectRestaurant
{
    class CMakeDishToTA : ICommand
    {
        private OrderTakeAway _order;
        private Dish _dish;
        private int _amount;
        private EChef _chef;
        public CMakeDishToTA(EChef chef, OrderTakeAway order, Dish dish, int amount)
        {
            _chef = chef;
            _order = order;
            _dish = dish;
            _amount = amount;
        }
        public void Execute()
        {
            for(int i=0; i<_amount; i++)
            {
                _order.MakeDish(_dish);
            }
        }
    }
}