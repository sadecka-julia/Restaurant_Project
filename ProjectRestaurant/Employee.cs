using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectRestaurant
{
    class Employee
    {
        private int _employeeID;
        private string _firstName;
        private string _lastName;
        private float _annualSallary;
        private int _monthHours;
        public Employee (int employeeID, string firstName, string lastName, float annualSallary, int monthHours)
        {
            _employeeID = employeeID;
            _firstName = firstName;
            _lastName = lastName;
            _annualSallary = annualSallary;
            _monthHours = monthHours;
        }

    }
}