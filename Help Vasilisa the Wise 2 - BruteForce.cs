using System;

class Program
{
    static void Main()
    {
        int row1, row2, col1, col2, diag1, diag2;
        row1 = int.Parse(Console.ReadLine());
        row2 = int.Parse(Console.ReadLine());
        col1 = int.Parse(Console.ReadLine());
        col2 = int.Parse(Console.ReadLine());
        diag1 = int.Parse(Console.ReadLine());
        diag2 = int.Parse(Console.ReadLine());

        int a, b, c, d;
        for (int i = 1; i < 10; i++)
        {
            a = i;
            for (int j = 1; j < 10; j++)
            {
                b = j;
                for (int k = 1; k < 10; k++)
                {
                    c = k;
                    for (int l = 1; l < 10; l++)
                    {
                        d = l;
                        if (a != b && a != c && a != d && b != c && b != d && c != d)
                        {
                            if (a + b == row1 && c + d == row2 && a + d == diag1 && b + c == diag2 && a + c == col1 && b + d == col2)
                            {
                                Console.WriteLine($"{a} {b}");
                                Console.WriteLine($"{c} {d}");
                                return;
                            }
                        }
                    }
                }
            }
        }

        Console.WriteLine(-1);
    }
}
