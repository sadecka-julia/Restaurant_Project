using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectRestaurant
{
    class CMakeReservation : ICommand
    {
        private Restaurant _restaurant; 
        private int _peopleAmount;
        private string _day;
        private int _hourfrom;
        public int time;

        public CMakeReservation(Restaurant restaurant, int peopleAmount, string day, int hourfrom)
        {
            _restaurant = restaurant;
            _peopleAmount = peopleAmount;
            _day = day;
            _hourfrom = hourfrom;
            time = 200;

        }
        public void Execute()
        {
            Table reserTable = null;
            Table tempTable = null;
            // Console.WriteLine($"TableID:");
            foreach(Table table in _restaurant.tables)
            {
                // Console.WriteLine($"TableID: {table.tableID}");
                if (table.capacity == _peopleAmount)
                {
                    // Console.WriteLine($"In pierwsz if TableID: {table.tableID}");
                    tempTable = table;
                    foreach(Reservation reservation in _restaurant.reservationsHistory)
                    {
                        // Console.WriteLine($"In foreach TableID: {table.tableID}");
                        if(reservation.table == tempTable && reservation.day == _day && (_hourfrom < reservation.hourto || _hourfrom+time>2200||_hourfrom>reservation.hourfrom-time || _hourfrom<1100))
                        {
                            tempTable = null;
                            // Console.WriteLine($"In drugi if TableID: {table.tableID}");
                        }
                    }
                    reserTable = tempTable;
                    break;

                }
            }
            if (reserTable != null)
                {
                    int numberID = (_restaurant.reservationsHistory.Count()) + 1;
                    Reservation newReservation = new Reservation(numberID, reserTable, _day, _hourfrom, _hourfrom+time);
                    _restaurant.reservationsHistory.Add(newReservation);
                    Console.WriteLine($"Make new reservation for table {reserTable.tableID} on {_hourfrom} day: {_day}.");
                }
            else if (reserTable == null)
                {
                    Console.WriteLine($"Couldn't make reservation for {_peopleAmount} people on {_hourfrom} on day: {_day} there is another reservation this time.");
                }
        }
    }
}