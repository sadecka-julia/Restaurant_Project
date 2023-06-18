using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectRestaurant
{
    class EManager : Employee
    {
        public EManager (int employeeID, string firstName, string lastName, float annualSallary, int monthHours): base( employeeID, firstName, lastName, annualSallary, monthHours)
        {

        }

    }
}