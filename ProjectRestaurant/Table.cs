using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectRestaurant
{
    class Table
    {
        public int tableID {get; set;}
        public int capacity {get; set;}
        public Table(int tableID, int capacity)
        {
            this.tableID = tableID;
            this.capacity = capacity;
        }

    }
}