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
            
            
            var employee = new Employee(firstName, lastName, annualSalary, superRate, startDate, " 31 March");
            
            Console.WriteLine("Name: " + employee.GenerateFullName());
            Console.WriteLine("Pay Period: " + employee.GeneratePayPeriod());
            Console.WriteLine("Gross Income: " + employee.CalculateGrossIncome());
            Console.WriteLine("Income Tax: " + employee.CalculateIncomeTax());
            Console.WriteLine("Net Income: " +employee.CalculateNetIncome());
            Console.WriteLine("Super: " + employee.CalculateSuper());
            
            Console.WriteLine("Thank you for using MYOB! " );
        }
    }
}