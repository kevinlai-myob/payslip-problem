using System;

namespace Payslip
{
    class Program
    {
        static void Main(string[] args)
        {   
            Console.WriteLine("Welcome to the payslip generator!");

            Employee kevin = new Employee("kevin", "lai", 55000, 0.09, "3 March", " 31 March");
            // Modify a property.
            // kevin.AnnualSalary += 500;
            // Console.WriteLine(kevin);
            // Console.WriteLine(kevin.CalculateGrossIncome(55000));
            // Console.WriteLine(kevin.CalculateIncomeTax(18201));
            // Console.WriteLine(kevin.CalculateNetIncome(18201));
            // Console.WriteLine(kevin.CalculateSuper(18201, 9));
            Console.WriteLine(kevin.GenerateFullName());
            Console.WriteLine("Please enter your annual salary: ");
        }
    }
}