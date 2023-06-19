using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectRestaurant
{
    class CRemoveDishFromOrderTA : ICommand
    {
        private OrderTakeAway _order;
        private Dish _dish;
        private EWaiter _waiter;
        public CRemoveDishFromOrderTA(EWaiter waiter, OrderTakeAway order, Dish dish)
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