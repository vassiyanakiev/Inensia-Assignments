using System;
using System.Collections.Generic;
using System.Text;

namespace SalaryCalculator
{
    public class TaxableIncomeCalculatorService
    {
        public double GetInsurableEarnings(double grossValue)
        {  
            if (grossValue > 3000)
            {
                var result = 2000;
                return result;
            }
            else if (grossValue > 1000 && grossValue <= 3000)
            {
                var result = grossValue - 1000;
                return result;
            }
            else 
            {
                return 0;
            }
        }

        public double GetTaxableIncome(double grossValue)
        {
            if (grossValue <= 1000)
            {
                return 0;
            }
            else
            {
                return grossValue - 1000;
            }
            
        }

        public double CalculateTax(double TaxableIncome)
        {
            return TaxableIncome * 0.10;
        }

        public double CalculateInsurance(double GrossIncome)
        {
            return GrossIncome * 0.15;
        }
    }
}
