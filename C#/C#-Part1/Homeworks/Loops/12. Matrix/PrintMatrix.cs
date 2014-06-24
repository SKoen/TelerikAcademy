using System;

class PrintMatrix
{
    static void Main()
    {
        Console.Write("Enter N = ");
        int n = int.Parse(Console.ReadLine());
        int[,] arr = new int[n, n];
        int number;
        for (int col = 0; col < n; col++)
        {
            number = col + 1;
            for (int row = 0; row < n; row++)
            {
                arr[row, col] = number++;
            }
        }

        for (int col = 0; col < n; col++)
        {
            for (int row = 0; row < n; row++)
            {
                Console.Write(arr[row, col]);
            }
            Console.WriteLine();
        }
    }
}

