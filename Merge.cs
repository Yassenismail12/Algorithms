using System;

class Program
{
    static void Main()
    {
        int[] arr = { 5, 2, 4, 6, 1, 3 };

        Console.WriteLine("Original Array:");
        PrintArray(arr);

        MergeSort(arr, 0, arr.Length - 1);

        Console.WriteLine("\nSorted Array:");
        PrintArray(arr);
    }

    static void MergeSort(int[] arr, int left, int right)
    {
        if (left < right)
        {
            int mid = (left + right) / 2;
            MergeSort(arr, left, mid);
            MergeSort(arr, mid + 1, right);
            Merge(arr, left, mid, right);
        }
    }

    static void Merge(int[] arr, int left, int mid, int right)
    {
        int n1 = mid - left + 1;
        int n2 = right - mid;

        int[] leftArr = new int[n1];
        int[] rightArr = new int[n2];

        for (int i = 0; i < n1; i++)
        {
            leftArr[i] = arr[left + i];
        }

        for (int j = 0; j < n2; j++)
        {
            rightArr[j] = arr[mid + 1 + j];
        }

        int k = left;
        int p = 0, q = 0;

        while (p < n1 && q < n2)
        {
            if (leftArr[p] <= rightArr[q])
            {
                arr[k] = leftArr[p];
                p++;
            }
            else
            {
                arr[k] = rightArr[q];
                q++;
            }
            k++;
        }

        while (p < n1)
        {
            arr[k] = leftArr[p];
            p++;
            k++;
        }

        while (q < n2)
        {
            arr[k] = rightArr[q];
            q++;
            k++;
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
