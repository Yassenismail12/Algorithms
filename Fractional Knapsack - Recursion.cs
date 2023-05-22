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

        return KnapsackRecursive(weights, values, capacity, n - 1);
    }

    static double KnapsackRecursive(int[] weights, int[] values, int capacity, int index)
    {
        // Base case: if no items left or no capacity remaining
        if (index < 0 || capacity <= 0)
            return 0;

        // If the weight of the current item is more than the remaining capacity,
        // skip the current item and move to the next item
        if (weights[index] > capacity)
            return KnapsackRecursive(weights, values, capacity, index - 1);

        // Recursive calls:
        // 1. Take the current item completely and reduce the capacity
        double takeCurrent = values[index] + KnapsackRecursive(weights, values, capacity - weights[index], index - 1);
        // 2. Skip the current item and move to the next item
        double skipCurrent = KnapsackRecursive(weights, values, capacity, index - 1);

        // Return the maximum value obtained by either taking or skipping the current item
        return Math.Max(takeCurrent, skipCurrent);
    }
}
