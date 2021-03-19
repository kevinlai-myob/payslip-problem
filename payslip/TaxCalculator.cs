using System;

namespace Payslip
{
    class TaxCalculator
    {
        private readonly int _annualSalary;
        private readonly int _superRate;

        public TaxCalculator(int annualSalary, int superRate)
        {
            _annualSalary = annualSalary;
            _superRate = superRate;

        }
        public double CalculateGrossIncome()
        {
            return Math.Floor(Convert.ToDouble(_annualSalary) / 12);
        }

        public double CalculateIncomeTax()
        {
            if (_annualSalary >= 0 && _annualSalary <= 18200)
            {
                return 0;
            }

            if (_annualSalary >= 18201 && _annualSalary <= 37000)
            {
                return 0.19 * (_annualSalary - 18200);
            }

            if (_annualSalary >= 37001 && _annualSalary <= 87000)
            {
                return 3572 + 0.325 * (_annualSalary - 37000);
            }

            if (_annualSalary >= 87001 && _annualSalary <= 180000)
            {
                return 19822 + 0.37 * (_annualSalary - 37000);
            }

            return 54232 + 0.45 * (_annualSalary - 180000);
        }

        public double CalculateNetIncome()
        {
            return _annualSalary - Math.Ceiling(CalculateIncomeTax());
        }

        public double CalculateSuper()
        {
            return CalculateGrossIncome() * _superRate / 100;
        }
    }
}