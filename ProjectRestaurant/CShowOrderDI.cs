namespace ProjectRestaurant
{
    class CShowOrderDI : ICommand
    {
        private OrderDineIn _order;

        public CShowOrderDI(OrderDineIn order)
        {
            _order = order;
        }
        public void Execute()
        {
            Console.WriteLine($"\nOrderID: {_order.orderID}");
            foreach( var dish in _order.dishes)
            {
                Console.WriteLine($"Dish: {dish.Value}x {dish.Key.name}");
            }
            
        }
    }
}