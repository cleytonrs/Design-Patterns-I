namespace DesignPatterns
{
    public interface IDiscount
    {
        double Discount(Budget budget);
        IDiscount Next { get; set; }
    }
}
