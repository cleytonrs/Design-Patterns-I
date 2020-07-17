namespace DesignPatterns
{
    public class NoDiscount : IDiscount
    {
        public IDiscount Next { get; set; }
        public double Discount(Budget budget)
        {
            return 0;
        }
    }
}
