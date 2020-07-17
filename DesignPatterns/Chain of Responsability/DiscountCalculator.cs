namespace DesignPatterns
{
    public class DiscountCalculator
    {
        public double Calculate(Budget budget)
        {
            IDiscount d1 = new DiscountForUpToFiveItems();
            IDiscount d2 = new DiscountForOverFiveHundredItems();
            IDiscount d3 = new NoDiscount();

            d1.Next = d2;
            d2.Next = d3;

            return d1.Discount(budget);
        }
    }
}
