using System;

class Program
{
    static void Main()
    {
        // No need to use freopen in C#

        long i, j, k;
        long a1, b1;
        long a2, b2;
        long a3, b3;

        string[] input1 = Console.ReadLine().Split();
        a1 = long.Parse(input1[0]);
        b1 = long.Parse(input1[1]);

        string[] input2 = Console.ReadLine().Split();
        a2 = long.Parse(input2[0]);
        b2 = long.Parse(input2[1]);

        string[] input3 = Console.ReadLine().Split();
        a3 = long.Parse(input3[0]);
        b3 = long.Parse(input3[1]);

        bool f = false;

        if (a1 >= Math.Max(a2, a3) && b2 + b3 <= b1)
            f = true;
        else if (a1 >= Math.Max(a2, b3) && b2 + a3 <= b1)
            f = true;
        else if (a1 >= Math.Max(a3, b2) && b3 + a2 <= b1)
            f = true;
        else if (a1 >= Math.Max(b2, b3) && a2 + a3 <= b1)
            f = true;
        else if (b1 >= Math.Max(a2, a3) && b2 + b3 <= a1)
            f = true;
        else if (b1 >= Math.Max(a2, b3) && b2 + a3 <= a1)
            f = true;
        else if (b1 >= Math.Max(a3, b2) && b3 + a2 <= a1)
            f = true;
        else if (b1 >= Math.Max(b2, b3) && a2 + a3 <= a1)
            f = true;

        if (f)
            Console.WriteLine("YES");
        else
            Console.WriteLine("NO");
    }
}
