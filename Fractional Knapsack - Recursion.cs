using System;

public class Item
{
    public int Weight { get; set; }
    public int Value { get; set; }

    public Item(int weight, int value)
    {
        Weight = weight;
        Value = value;
    }
}

public class FractionalKnapsack
{
    public static double GetMaxValue(Item[] items, int capacity)
    {
        // Sort items by value-to-weight ratio in descending order
        Array.Sort(items, (a, b) => (b.Value / b.Weight).CompareTo(a.Value / a.Weight));

        double totalValue = 0;
        int remainingCapacity = capacity;

        foreach (Item item in items)
        {
            if (remainingCapacity == 0)
                break;

            // Take the whole item if it fits
            if (item.Weight <= remainingCapacity)
            {
                totalValue += item.Value;
                remainingCapacity -= item.Weight;
            }
            else
            {
                // Take a fraction of the item
                double fraction = (double)remainingCapacity / item.Weight;
                totalValue += fraction * item.Value;
                break;
            }
        }

        return totalValue;
    }

    public static void Main(string[] args)
    {
        // Example usage
        Item[] items = new Item[]
        {
            new Item(10, 60),
            new Item(20, 100),
            new Item(30, 120)
        };

        int capacity = 50;

        double maxValue = GetMaxValue(items, capacity);
        Console.WriteLine("Maximum value: " + maxValue);
    }
}
