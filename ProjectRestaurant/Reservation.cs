using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectRestaurant
{
    class Reservation
    {
        public int reservationID {get; set;}
        public Table table;
        public string day {get; set;}
        public int hourfrom {get; set;}
        public int hourto {get; set; }
    
        public Reservation(int reservationID, Table table, string day, int hourfrom, int hourto)
        {
            this.reservationID = reservationID;
            this.table = table;
            this.day = day;
            this.hourfrom = hourfrom;
            this.hourto = hourto; 
        }
    }
}