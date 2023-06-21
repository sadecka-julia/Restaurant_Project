namespace ProjectRestaurant
{
    class CGenerateBillDI : ICommand
    {
        private OrderDineIn _order;

        public CGenerateBillDI(OrderDineIn order)
        {
            _order = order;
        }
        public void Execute()
        {
            float sum = 0;
            Console.WriteLine($"\nBill for Order: {_order.orderID}");
            foreach( var dish in _order.dishes)
            {
                sum += dish.Value*dish.Key.price;
                Console.WriteLine($"{dish.Value}x {dish.Key.name}    ={dish.Value*dish.Key.price}zł");
            }
            Console.WriteLine($"Total: {sum}zł");

            
        }
    }
}