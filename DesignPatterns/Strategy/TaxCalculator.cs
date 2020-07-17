using System;

namespace DesignPatterns
{
    public class TaxCalculator
    {
        public void Calculate(Budget budget, ITax tax)
        {
            double result = tax.Calculate(budget);
            Console.WriteLine(result);
        }
    }
}
