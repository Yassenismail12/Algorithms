using System;

class Program
{
    static void Main()
    {
        int[] arr = { 1, 2, 3, 4,5, 6 };
        int target = 4;
        int l = 0;
        int r = arr.Length - 1;
        int index = -1;

        while (l <= r)
        {
            int mid = (l + r) / 2;

            if (arr[mid] == target)
            {
                index = mid;
                break;
            }
            else if (arr[mid] < target)
            {
                l = mid + 1;
            }
            else
            {
                r = mid - 1;
            }
        }

        if (index != -1)
        {
            Console.WriteLine("\nFound!");
        }
        else
        {
            Console.WriteLine("\nTarget not found in the array.");
        }
        
    }
}
