using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectRestaurant
{
    class OrderTakeAway : IOrder
    {
        public int orderID {get; set;}
        private string _hoursOfTake;
        public Dictionary<Dish, int> dishes = new Dictionary<Dish, int>();
        public Dictionary<Dish, string> history = new Dictionary<Dish, string>(); 
        public float sum;
        public OrderTakeAway(int orderID, string hoursOfTake)
        {
            this.orderID = orderID;
            _hoursOfTake = hoursOfTake;
            foreach( var dish in dishes)
            {
                sum += dish.Value*dish.Key.price;
            }
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
                dish.Amount -= 1;
            }
            else
            {
                history.Add(dish, "Add");
                dishes.Add(dish, 1);
                dish.Amount -= 1;
            }
            
            Console.WriteLine($"Add '{dish.name}' to order {orderID}");
        }
        public void RemoveDish(Dish dish)
        {
            if (dishes.ContainsKey(dish) && dishes[dish] > 0)
            {
                history[dish] += "Rem";
                dishes[dish] -= 1;
                dish.Amount += 1;
                Console.WriteLine($"Remove '{dish.name}' from order {orderID}");
            }
            else
            {
                Console.WriteLine($"Dish {dish.name} isn't in order.");
            }
        }
        public void MakeDish(Dish dish)
        {
            if (history.ContainsKey(dish) && dishes[dish] > 0)
            {
                history[dish] += "Make";
                dishes[dish] -= 1;
                Console.WriteLine($"Make '{dish.name}' from order {orderID}");
            }
            else
            {
                Console.WriteLine($"Can't make '{dish.name}' because it is not in order {orderID}");
            }          
        }
    }
}