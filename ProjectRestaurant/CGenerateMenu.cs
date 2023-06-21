namespace ProjectRestaurant
{
    class CGenerateMenu : ICommand
    {
        private Menu _menu;

        public CGenerateMenu(Menu menu)
        {
            _menu = menu;
        }
        public void Execute()
        {
            Console.WriteLine($"\nMenu");
            foreach( Dish dish in _menu.dishes)
            {
                if(dish.Amount>0)
                {
                    Console.WriteLine($"Dish: {dish.name}, Price: {dish.price}");
                }
            } 
            foreach(Beverage beverage in _menu.beverages)
            {
                if(beverage.Amount>0)
                {
                    Console.WriteLine($"Beverage: {beverage.name}, Price: {beverage.price}");
                }
            } 
        }
    }
}