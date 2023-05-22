using System;

class Program
{
    static void Main()
    {
        int[] weights = { 10, 20, 30 };
        int[] values = { 60, 100, 120 };
        int capacity = 50;

        double maxValue = FractionalKnapsack(weights, values, capacity);

        Console.WriteLine("Maximum value: " + maxValue);
    }

    static double FractionalKnapsack(int[] weights, int[] values, int capacity)
    {
        int n = weights.Length;

        // Calculate value-to-weight ratio for each item
        double[] ratios = new double[n];
        for (int i = 0; i < n; i++)
        {
            ratios[i] = (double)values[i] / weights[i];
        }

        // Sort items in descending order of value-to-weight ratio
        Array.Sort(ratios, weights, values);
        Array.Reverse(ratios);
        Array.Reverse(weights);
        Array.Reverse(values);

        double totalValue = 0;

        for (int i = 0; i < n; i++)
        {
            if (capacity <= 0)
                break;

            if (weights[i] <= capacity)
            {
                // Take the whole item
                totalValue += values[i];
                capacity -= weights[i];
            }
            else
            {
                // Take a fraction of the item
                double fraction = (double)capacity / weights[i];
                totalValue += fraction * values[i];
                capacity = 0;
            }
        }

        return totalValue;
    }
}
