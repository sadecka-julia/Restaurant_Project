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

            restaurant.AddTable(table1);
            restaurant.AddTable(table2);
            restaurant.AddTable(table3);
            restaurant.AddTable(table4);
            restaurant.AddTable(table5);
            restaurant.AddTable(table6);


            // DOdanie potraw
            Dish dish1 = new Dish(1, "Zupa pomidorowa", 9, 30);
            Dish dish2 = new Dish(2, "Rosół", 8, 28);
            Dish dish3 = new Dish(3, "Kotlet schabowy", 20, 19);
            Dish dish4 = new Dish(4, "Devoile", 15, 15);
            Dish dish5 = new Dish(5, "Pierogi ruskie", 16, 30);
            Dish dish6 = new Dish(6, "Pierogi z mięsem", 19, 28);
            Dish dish7 = new Dish(7, "Bigos", 12, 35);
            Dish dish8 = new Dish(8, "Spagethi", 15, 30);
            Beverage beverage1 = new Beverage(5, "Cola", 5, 15, true);
            Beverage beverage2 = new Beverage(6, "Cola", 5, 14, false);
            Beverage beverage3 = new Beverage(7, "Lemon", 6, 5, true);
            Beverage beverage4 = new Beverage(8, "Lemon", 6, 15, false);

            menu.AddDish(dish1);
            menu.AddDish(dish2);
            menu.AddDish(dish3);
            menu.AddDish(dish4);
            menu.AddDish(dish5);
            menu.AddDish(dish6);
            menu.AddDish(dish7);
            menu.AddDish(dish8);
            menu.AddBeverage(beverage1);
            menu.AddBeverage(beverage2);
            menu.AddBeverage(beverage3);
            menu.AddBeverage(beverage4);

            // Stworzenie pracowników
            EChef chef1 = new EChef(1, "Adam", "Małysz", 4000, 30);
            EChef chef2 = new EChef(2, "Kamil", "Stoch", 4100, 35);
            EManager manager3 = new EManager(3, "Jakub", "Błaszczykowski", 7500, 40);
            EWaiter waiter4 = new EWaiter(4, "Iga", "Świątek", 3500, 30);
            EWaiter waiter5 = new EWaiter(5, "Justyna", "Święty", 4000, 35);

            restaurant.AddChef(chef1);
            restaurant.AddChef(chef2);
            restaurant.AddManager(manager3);
            restaurant.AddWaiter(waiter4);
            restaurant.AddWaiter(waiter5);


            
            // Pierwsze zamówienie - stworzenie zamówienia
            Console.WriteLine($"\n-------------First Order-----------------");
            OrderService os = new OrderService();
            OrderDineIn order1 = new OrderDineIn(1, table1);
            restaurant.AddDineInOrder(order1);

            CAddDishToOrderDI add11 = new CAddDishToOrderDI(waiter4, order1, dish1, 1);
            CAddDishToOrderDI add12 = new CAddDishToOrderDI(waiter4, order1, dish2, 1);
            CAddDishToOrderDI add13 = new CAddDishToOrderDI(waiter4, order1, dish3, 2);
            CAddDishToOrderDI add14 = new CAddDishToOrderDI(waiter4, order1, dish4, 1);
            os.AddCommand(add11);
            os.AddCommand(add12);
            os.AddCommand(add13);
            os.AddCommand(add14);

            // Usunięcie produktu z zamówieni, a następnie następnego, którego już nie ma
            // Pokazanie dań z zamówienia
            // Wygenerowanie rachunku zamówienia
            CRemoveDishFromOrderDI rem1 = new CRemoveDishFromOrderDI(waiter4, order1, dish1);
            CShowOrderDI showOr = new CShowOrderDI(order1);
            CGenerateBillDI bill1 = new CGenerateBillDI(order1);
            os.AddCommand(rem1);
            os.AddCommand(rem1);
            os.AddCommand(showOr);
            os.AddCommand(bill1);
            os.MakeCommands();

            // Drugie zamówienie (take order)
            Console.WriteLine($"\n---------------Secound Order----------------");
            OrderTakeAway order2 = new OrderTakeAway(2, "1500");
            restaurant.AddTakeAwayOrder(order2);
            CAddDishToOrderTA add21 = new CAddDishToOrderTA(order2, dish4, 4);
            CAddDishToOrderTA add22 = new CAddDishToOrderTA(order2, dish3, 2);
            CAddDishToOrderTA add23 = new CAddDishToOrderTA(order2, dish2, 1);
            os.AddCommand(add21);
            os.AddCommand(add22);
            os.AddCommand(add23);
            // Wykonanie zamówienia, a następnie spróbowanie usunęcia go
            CMakeDishToTA mkdi1 = new CMakeDishToTA(chef1, order2, dish4, 4);
            CRemoveDishFromOrderTA rm2 = new CRemoveDishFromOrderTA(waiter5, order2, dish4);
            os.AddCommand(mkdi1);
            os.AddCommand(rm2);
            os.MakeCommands();

             Console.WriteLine($"\n-------------Firth Order-----------------");
            OrderDineIn order3 = new OrderDineIn(3, table6);
            restaurant.AddDineInOrder(order3);

            CAddDishToOrderDI add31 = new CAddDishToOrderDI(waiter5, order3, dish5, 2);
            CAddDishToOrderDI add32 = new CAddDishToOrderDI(waiter5, order3, dish7, 4);
            CAddDishToOrderDI add33 = new CAddDishToOrderDI(waiter5, order3, dish8, 4);
            CAddDishToOrderDI add34 = new CAddDishToOrderDI(waiter5, order3, dish6, 4);
            os.AddCommand(add31);
            os.AddCommand(add32);
            os.AddCommand(add33);
            os.AddCommand(add34);

            CGenerateBillDI bill3 = new CGenerateBillDI(order3);
            os.AddCommand(bill3);

            
            // Rezerwacje
            Console.WriteLine($"\n-----------Reservations---------");
            Reservation probna = new Reservation(1, table1, "11.03.2023", 1500, 1630);
            CMakeReservation res1 = new CMakeReservation(restaurant, 3, "12.03.2023", 1400);
            CMakeReservation res2 = new CMakeReservation(restaurant, 3, "12.03.2023", 1410);
            CMakeReservation res3 = new CMakeReservation(restaurant, 4, "15.03.2023", 2000);
            CMakeReservation res4 = new CMakeReservation(restaurant, 2, "21.03.2023", 1900);
            CMakeReservation res5 = new CMakeReservation(restaurant, 2, "21.03.2023", 1800);
            CReservationList list = new CReservationList(restaurant);
            CRemoveReservation rmres = new CRemoveReservation(restaurant, 2);
            restaurant.AddReservation(probna);
            os.AddCommand(res1);
            os.AddCommand(res2);  
            os.AddCommand(res3);
            os.AddCommand(res4); 
            os.AddCommand(res5);        
            os.AddCommand(list);            
            os.AddCommand(rmres);
            os.AddCommand(list);
            os.MakeCommands();

            // Raporty
            CGenerateOrdersReport orderReport = new CGenerateOrdersReport(restaurant);
            CGenerateMenu menuu = new CGenerateMenu(menu);
            os.AddCommand(orderReport);
            os.AddCommand(menuu);
            os.AddCommand(list);
            os.MakeCommands();

            

        }
    }
}