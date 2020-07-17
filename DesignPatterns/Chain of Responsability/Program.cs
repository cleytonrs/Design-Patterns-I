using DesignPatterns;
using System;

namespace Chain_of_Responsability
{
    class Program
    {
        private static void Main(string[] args)
        {
            DiscountCalculator discountCalculator = new DiscountCalculator();

            Budget budget = new Budget(500);
            budget.AddItem(new Item("Pencil", 250));
            budget.AddItem(new Item("Pen", 250));
            budget.AddItem(new Item("Book", 250));
            budget.AddItem(new Item("Eraser", 250));
            budget.AddItem(new Item("School Uniform", 250));
            budget.AddItem(new Item("school", 250));

            double discount = discountCalculator.Calculate(budget);
            Console.WriteLine(discount);

            Console.ReadKey();
        }
    }
}
