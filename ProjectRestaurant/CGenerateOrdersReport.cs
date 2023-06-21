namespace ProjectRestaurant
{
    class CGenerateOrdersReport : ICommand
    {
        private Restaurant restaurant;

        public CGenerateOrdersReport(Restaurant restaurant)
        {
            this.restaurant = restaurant;
        }
        public void Execute()
        {
            Console.WriteLine($"\nOrders Report");
            float sumAll = 0; 
            Console.WriteLine($"Orders Dine In: ");

            foreach(OrderDineIn orderDI in restaurant.dineInOrders)
            {
                float orderSum = 0;
                foreach( var dish in orderDI.dishes)
                {
                    orderSum += dish.Value*dish.Key.price;
                }
                sumAll += orderSum;
                Console.WriteLine($"OrderID: {orderDI.orderID}: Sum: {orderSum}");
            }
            Console.WriteLine($"Sum of orders Dine In: {sumAll}");

            Console.WriteLine($"\nOrders Take Away:");
            foreach (OrderTakeAway orderTA in restaurant.takeAwayOrders)
            {
                float orderSumTA = 0;
                foreach( var dish in orderTA.dishes)
                {
                    orderSumTA += dish.Value*dish.Key.price;
                }
                sumAll += orderSumTA;
                sumAll += orderTA.sum;
                Console.WriteLine($"OrderID: {orderTA.orderID}: Sum: {orderSumTA}");
            }
            Console.WriteLine($"Total orders sum: {sumAll}"); 
        }
    }
}