namespace ProjectRestaurant
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Making Restaurant
            Menu menu = new Menu();
            Restaurant restaurant = new Restaurant("Szybko i Smacznie", "Majowa 6, Katowice", menu);
            Table table1 = new Table(1, 2);
            Table table2 = new Table(2, 2);
            Table table3 = new Table(3, 4);
            Table table4 = new Table(4, 3);
            Table table5 = new Table(5, 6);
            Table table6 = new Table(6, 5);

            // Adding Dishes to Menu
            Dish dish1 = new Dish(1, "Zupa pomidorowa", 9, 4);
            Dish dish2 = new Dish(2, "Rosół", 8, 5);
            Dish dish3 = new Dish(3, "Kotlet schabowy", 20, 7);
            Dish dish4 = new Dish(4, "Devoile", 15, 6);
            Beverage beverage1 = new Beverage(5, "Cola", 5, 15, true);
            Beverage beverage2 = new Beverage(6, "Cola", 5, 14, false);
            Beverage beverage3 = new Beverage(7, "Lemon", 6, 5, true);
            Beverage beverage4 = new Beverage(8, "Lemon", 6, 15, false);

            menu.AddDish(dish1);
            menu.AddDish(dish2);
            menu.AddDish(dish3);
            menu.AddDish(dish4);
            menu.AddBeverage(beverage1);
            menu.AddBeverage(beverage2);
            menu.AddBeverage(beverage3);
            menu.AddBeverage(beverage4);

            // Making Employees
            EChef chef1 = new EChef(1, "Adam", "Małysz", 4000, 30);
            EChef chef2 = new EChef(2, "Kamil", "Stoch", 4100, 35);
            EManager manager3 = new EManager(3, "Jakub", "Błaszczykowski", 7500, 40);
            EWaiter waiter4 = new EWaiter(4, "Iga", "Świątek", 3500, 30);
            EWaiter waiter5 = new EWaiter(5, "Justyna", "Święty", 4000, 35);
            
            // Making logic
            OrderService os = new OrderService();
            OrderDineIn order1 = new OrderDineIn(1, table1);
            CAddDishToOrderDI add1 = new CAddDishToOrderDI(waiter4, order1, dish1, 1);
            CAddDishToOrderDI add2 = new CAddDishToOrderDI(waiter4, order1, dish2, 1);
            CAddDishToOrderDI add3 = new CAddDishToOrderDI(waiter4, order1, dish3, 2);
            CAddDishToOrderDI add4 = new CAddDishToOrderDI(waiter4, order1, dish4, 1);
            os.AddCommand(add1);
            os.AddCommand(add2);
            os.AddCommand(add3);
            os.AddCommand(add4);
            os.MakeCommands();

            CRemoveDishFromOrderDI rem1 = new CRemoveDishFromOrderDI(waiter4, order1, dish1);
            os.AddCommand(rem1);
            os.MakeCommands();
            os.AddCommand(rem1);
            os.MakeCommands();
            

        }
    }
}