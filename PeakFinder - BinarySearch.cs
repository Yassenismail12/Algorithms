using System;

class Program
{
    static void Main()
    {
        int[] arr = { 1, 3, 2, 4, 6, 5 };

        int peak = FindPeak(arr);

        Console.WriteLine("Peak element: " + peak);
    }

    static int FindPeak(int[] arr)
    {
        int left = 0;
        int right = arr.Length - 1;

        while (left < right)
        {
            int mid = left + (right - left) / 2;

            // Check if the middle element is a peak
            if (arr[mid] > arr[mid - 1] && arr[mid] > arr[mid + 1])
            {
                return arr[mid];
            }
            // If the element to the right is greater, peak lies on the right side
            else if (arr[mid] < arr[mid + 1])
            {
                left = mid + 1;
            }
            // If the element to the left is greater, peak lies on the left side
            else
            {
                right = mid - 1;
            }
        }

        // If left and right pointers meet, the single remaining element is a peak
        return arr[left];
    }
}
