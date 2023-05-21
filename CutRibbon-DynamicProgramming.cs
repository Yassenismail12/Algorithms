using System;

class Program
{
    static int MaximizeRibbonPieces(int n, int a, int b, int c)
    {
        int[] dp = new int[n + 1];
        dp[0] = 0;

        for (int i = 1; i <= n; i++)
        {
            dp[i] = -1;  // Initialize with an invalid value

            // Try cutting the rope using each value a, b, and c
            if (i >= a && dp[i - a] != -1)
            {
                dp[i] = Math.Max(dp[i], dp[i - a] + 1);
            }

            if (i >= b && dp[i - b] != -1)
            {
                dp[i] = Math.Max(dp[i], dp[i - b] + 1);
            }

            if (i >= c && dp[i - c] != -1)
            {
                dp[i] = Math.Max(dp[i], dp[i - c] + 1);
            }
        }

        return dp[n];
    }

    static void Main()
    {
        string[] values = Console.ReadLine().Split(' ');
        int n = int.Parse(values[0]);
        int a = int.Parse(values[1]);
        int b = int.Parse(values[2]);
        int c = int.Parse(values[3]);
        int maxPieces = MaximizeRibbonPieces(n, a, b, c);
        Console.WriteLine(maxPieces);
    }
}
