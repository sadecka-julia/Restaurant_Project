using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectRestaurant
{
    class CReservationList : ICommand
    {
        private Restaurant _restaurant;
        public CReservationList(Restaurant restaurant)
        {
            _restaurant = restaurant;
        }
        public void Execute()
        {
            Console.WriteLine($"\nReservation list: ");
            foreach( Reservation reservation in _restaurant.reservationsHistory)
            {
                Console.WriteLine($"ReservationID: {reservation.reservationID}, Day: {reservation.day}, Hour: {reservation.hourfrom} to: {reservation.hourto}. Table: {reservation.table.tableID}");
            }
        }
    }
}