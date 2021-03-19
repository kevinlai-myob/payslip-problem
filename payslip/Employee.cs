using System;

namespace Payslip
// This class is mutable. Its data can be modified from outside the class.
{
    class Employee
    {
        // Auto-implemented properties for trivial get and set
        private readonly string _firstName;
        private readonly string _lastName;
        private readonly string _startDate;
        private readonly string _endDate;

        // Constructor
        public Employee ( string firstName, string lastName, string startDate, string endDate) 
        {
            _firstName = firstName;
            _lastName = lastName;
            _startDate = startDate;
            _endDate = endDate;
        }

        // Methods
        public string GenerateFullName()
        {
            return $"{_firstName} {_lastName}";
        }

        public string GeneratePayPeriod()
        {
            return $"{_startDate} - {_endDate}";
        }
    }
}
