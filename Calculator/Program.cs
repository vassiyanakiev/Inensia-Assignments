using System;

namespace SalaryCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double grossValue = double.Parse(Console.ReadLine());
     
            var service = new TaxableIncomeCalculatorService();
            var totalTax = service.CalculateTax(service.GetTaxableIncome(grossValue))
                + service.CalculateInsurance(service.GetInsurableEarnings(grossValue));
            var netSalary = grossValue - totalTax;

            Console.WriteLine($"Total Tax: {totalTax} IDR\nNet Salary: {netSalary} IDR");

        }

        
    }
}
