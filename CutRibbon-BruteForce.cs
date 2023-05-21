using System;

class Program
{
    static int MaximizeRibbonPieces(int n, int a, int b, int c)
    {
        int maxPieces = 0;

        for (int i = 0; i <= n; i++)
        {
            for (int j = 0; j <= n - i; j++)
            {
                int k = n - i - j;
                int totalPieces = i / a + j / b + k / c;
                int remaining = i % a + j % b + k % c;

                if (remaining == 0)
                {
                    maxPieces = Math.Max(maxPieces, totalPieces);
                }
            }
        }

        return maxPieces;
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
