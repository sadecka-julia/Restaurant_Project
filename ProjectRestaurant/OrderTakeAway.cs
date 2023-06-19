using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectRestaurant
{
    class OrderTakeAway : IOrder
    {
        public int OrderID {get; set;}
        private string _hoursOfTake;
        public Dictionary<Dish, int> dishes = new Dictionary<Dish, int>();
        public Dictionary<Dish, string> history = new Dictionary<Dish, string>(); 
        private float _sum;
        public OrderTakeAway(int orderID, string hoursOfTake)
        {
            OrderID = orderID;
            _hoursOfTake = hoursOfTake;
        }
        public void TakeOrder()
        {
            
        }
        public void AddDish(Dish dish)
        {
            if (dishes.ContainsKey(dish))
            {
                history[dish] += " Add";
                dishes[dish] += 1;
            }
            else
            {
                history.Add(dish, "Add");
                dishes.Add(dish, 1);
            }
            
            Console.WriteLine($"Add '{dish.Name}' to order {OrderID}");
        }
        public void RemoveDish(Dish dish)
        {
            if (dishes.ContainsKey(dish) && dishes[dish] > 0)
            {
                history[dish] += "Rem";
                dishes[dish] -= 1;
                Console.WriteLine($"Remove '{dish.Name}' from order {OrderID}");
            }
            else
            {
                Console.WriteLine($"Dish {dish.Name} isn't in order.");
            }
        }
        public void MakeDish(Dish dish)
        {
            if (history.ContainsKey(dish) && dishes[dish] > 0)
            {
                history[dish] += "Make";
                dishes[dish] -= 1;
                Console.WriteLine($"Make '{dish.Name}' from order {OrderID}");
            }
            else
            {
                Console.WriteLine($"Can't make '{dish.Name}' because it is not in order {OrderID}");
            }          
        }
        public void GiveDish(){}
    }
}