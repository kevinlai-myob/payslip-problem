using System;

namespace Payslip
{
    class Program
    {
        static void Main(string[] args)
        {   
            
            Console.WriteLine("Welcome to the payslip generator!");
            Console.Write("Please input your first name: ");
            var firstName = Console.ReadLine();
            
            Console.Write("Please input your last name: ");
            var lastName = Console.ReadLine();
            
            Console.Write("Please enter your annual salary: ");
            var annualSalary = int.Parse(Console.ReadLine());
            
            Console.Write("Please enter your payment start date:");
            var startDate = Console.ReadLine();
            
            Console.Write("Please enter your payment end date:");
            var endDate = Console.ReadLine();
            
            Console.Write("Please input your super rate: ");
            var superRate = int.Parse(Console.ReadLine());
            
            
            var employee = new Employee(firstName, lastName, startDate, " 31 March");
            var taxCalculator = new TaxCalculator(annualSalary, superRate);
            Console.WriteLine("Name: " + employee.GenerateFullName());
            Console.WriteLine("Pay Period: " + employee.GeneratePayPeriod());
            Console.WriteLine("Gross Income: " + taxCalculator.CalculateGrossIncome());
            Console.WriteLine("Income Tax: " + taxCalculator.CalculateIncomeTax());
            Console.WriteLine("Net Income: " +taxCalculator.CalculateNetIncome());
            Console.WriteLine("Super: " + taxCalculator.CalculateSuper());
            
            Console.WriteLine("Thank you for using MYOB! " );
        }
    }
}