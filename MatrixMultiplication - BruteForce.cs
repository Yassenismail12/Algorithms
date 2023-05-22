using System;
//O(N^3)
class Program
{
    static void Main()
    {
        int N = 3; // Size of the matrices

        // Define the input matrices A and B
        int[,] A = new int[N, N] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
        int[,] B = new int[N, N] { { 9, 8, 7 }, { 6, 5, 4 }, { 3, 2, 1 } };

        // Create an empty matrix C to store the result
        int[,] C = new int[N, N];

        // Call the multiply function
        Multiply(A, B, C);

        // Display the result matrix C
        Console.WriteLine("Result:");
        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < N; j++)
            {
                Console.Write(C[i, j] + " ");
            }
            Console.WriteLine();
        }
    }

    static void Multiply(int[,] A, int[,] B, int[,] C)
    {
        int N = A.GetLength(0); // Get the size of matrices

        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < N; j++)
            {
                C[i, j] = 0;
                for (int k = 0; k < N; k++)
                {
                    C[i, j] += A[i, k] * B[k, j];
                }
            }
        }
    }
}
