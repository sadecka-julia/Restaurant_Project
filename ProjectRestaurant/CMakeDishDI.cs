using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectRestaurant
{
    class CMakeDishToDI : ICommand
    {
        private OrderDineIn _order;
        private Dish _dish;
        private int _amount;
        private EChef _chef;
        public CMakeDishToDI(EChef chef, OrderDineIn order, Dish dish, int amount)
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