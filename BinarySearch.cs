using System;

class Program
{
    static void Main()
    {
        int[] arr = { 1, 2, 3, 4, 5, 6 };
        int target = 4;

        Console.WriteLine("Array:");
        PrintArray(arr);

        int left = 0;
        int right = arr.Length - 1;
        int index = -1;

        while (left <= right)
        {
            int mid = (left + right) / 2;

            if (arr[mid] == target)
            {
                index = mid;
                break;
            }
            else if (arr[mid] < target)
            {
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
        }

        if (index != -1)
        {
            Console.WriteLine("\nTarget found at index: " + index);
        }
        else
        {
            Console.WriteLine("\nTarget not found in the array.");
        }
    }

    static void PrintArray(int[] arr)
    {
        foreach (int num in arr)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }
}
