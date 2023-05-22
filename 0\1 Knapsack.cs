using System;

class Program
{
    static void Main()
    {
        int[] weights = { 10, 20, 30 };
        int[] values = { 60, 100, 120 };
        int capacity = 50;

        int maxValue = Knapsack(weights, values, capacity);

        Console.WriteLine("Maximum value: " + maxValue);
    }

    static int Knapsack(int[] weights, int[] values, int capacity)
    {
        int n = weights.Length;

        int[,] dp = new int[n + 1, capacity + 1];

        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= capacity; j++)
            {
                if (weights[i - 1] <= j)
                {
                    dp[i, j] = Math.Max(values[i - 1] + dp[i - 1, j - weights[i - 1]], dp[i - 1, j]);
                }
                else
                {
                    dp[i, j] = dp[i - 1, j];
                }
            }
        }

        return dp[n, capacity];
    }
}
