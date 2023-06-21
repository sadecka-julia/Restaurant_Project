using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectRestaurant
{
    class Restaurant
    {
        private string _name;
        private string _address;
        private Menu _menu;
        private List<Employee> employees = new List<Employee>();
        private List<EChef> chefs = new List<EChef>();
        private List<EManager> managers = new List<EManager>();
        private List<EWaiter> waiters = new List<EWaiter>();
        public List<Table> tables = new List<Table>();
        public List<Reservation> reservationsHistory = new List<Reservation>();
        public List<OrderDineIn> dineInOrders = new List<OrderDineIn>();
        public List<OrderTakeAway> takeAwayOrders = new List<OrderTakeAway>();
        public Restaurant(string name, string address, Menu menu)
        {
            _name = name;
            _address = address;
            _menu = menu;
        }
        public void AddChef(EChef chef)
        {
            chefs.Add(chef);
            employees.Add(chef);
        }
        public void AddManager(EManager manager)
        {
            managers.Add(manager);
            employees.Add(manager);
        }
        public void AddWaiter(EWaiter waiter)
        {
            waiters.Add(waiter);
            employees.Add(waiter);
        }
        public void AddTable(Table table)
        {
            tables.Add(table);
        }
        public void AddReservation(Reservation reservation)
        {
            reservationsHistory.Add(reservation);
        }
        public void AddDineInOrder(OrderDineIn order)
        {
            dineInOrders.Add(order);
        }
        public void AddTakeAwayOrder(OrderTakeAway order)
        {
            takeAwayOrders.Add(order);
        }
    }
}