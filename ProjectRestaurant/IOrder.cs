using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectRestaurant
{
    interface IOrder
    {
        void TakeOrder();
        void AddDish(Dish dish);
        void RemoveDish(Dish dish);
    }
}