using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectRestaurant
{
    class CRemoveDishFromOrderDI : ICommand
    {
        private OrderDineIn _order;
        private Dish _dish;
        private EWaiter _waiter;
        public CRemoveDishFromOrderDI(EWaiter waiter, OrderDineIn order, Dish dish)
        {
            _waiter = waiter;
            _order = order;
            _dish = dish;
        }
        public void Execute()
        {

            _order.RemoveDish(_dish);

        }
    }
}