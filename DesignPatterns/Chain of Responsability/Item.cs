using System;

namespace DesignPatterns
{
    public class Item
    {
        public String Name { get; private set; }
        public double Value { get; private set; }

        public Item(String name, double value)
        {
            this.Name = name;
            this.Value = value;
        }
    }
}
