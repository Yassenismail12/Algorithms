using System;

public class FibonacciDP
{
    public static long Fibonacci(int n)
    {
        // Create a DP table to store Fibonacci values
        long[] dp = new long[n + 1];

        // Base cases
        dp[0] = 0;
        dp[1] = 1;

        // Calculate Fibonacci values using DP
        for (int i = 2; i <= n; i++)
        {
            dp[i] = dp[i - 1] + dp[i - 2];
        }

        return dp[n];
    }

    public static void Main(string[] args)
    {
        // Example usage
        int n = 10;
        long result = Fibonacci(n);
        Console.WriteLine("Fibonacci(" + n + ") = " + result);
    }
}
