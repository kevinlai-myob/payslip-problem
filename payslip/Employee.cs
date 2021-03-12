using System;

namespace Payslip
// This class is mutable. Its data can be modified from outside the class.
{
    class Employee
    {
        // Auto-implemented properties for trivial get and set
        public string FirstName { get; set;}
        public string LastName {get; set;}
        public int AnnualSalary {get; set;}
        public int SuperRate {get; set;}
        public string StartDate {get; set;}
        public string EndDate {get; set;}

        // Constructor
        public Employee ( string firstName, string lastName, int annualSalary, int superRate, string startDate, string endDate) 
        {
            FirstName = firstName;
            LastName = lastName;
            AnnualSalary = annualSalary;
            SuperRate = superRate;
            StartDate = startDate;
            EndDate = endDate;
        }

        // Methods
        public string GenerateFullName()
        {
            return $"{FirstName} {LastName}";
        }

        public string GeneratePayPeriod()
        {
            return $"{StartDate} - {EndDate}";
        }

        public double CalculateGrossIncome()
        {
            return Math.Floor(Convert.ToDouble(AnnualSalary)/12);
        }

        public double CalculateIncomeTax()
        {
            if (AnnualSalary >= 0 && AnnualSalary <= 18200)
            {
                return 0;
            }
            if (AnnualSalary >= 18201 && AnnualSalary <= 37000)
            {
                return 0.19 * (AnnualSalary - 18200);
            }
            if (AnnualSalary >= 37001 && AnnualSalary <= 87000)
            {
                return 3572 + 0.325*(AnnualSalary - 37000);
            }
            if (AnnualSalary >= 87001 && AnnualSalary <= 180000)
            {
                return 19822 + 0.37*(AnnualSalary - 37000);
            }
            return 54232 + 0.45*(AnnualSalary - 180000);
        }

        public double CalculateNetIncome()
        {
            return AnnualSalary - Math.Ceiling(CalculateIncomeTax());
        }

        public double CalculateSuper()
        {
            return CalculateGrossIncome() * SuperRate/100;
        }
    }
}
