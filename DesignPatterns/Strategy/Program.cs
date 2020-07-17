using System;

namespace DesignPatterns
{
    class Program
    {
        private static void Main(string[] args)
        {
            ITax iss = new ISS();
            ITax icms = new ICMS();

            Budget budget = new Budget(500.0);
            TaxCalculator taxCalculator = new TaxCalculator();

            taxCalculator.Calculate(budget, iss);
            taxCalculator.Calculate(budget, icms);

            Console.ReadKey();
        }
    }
}
