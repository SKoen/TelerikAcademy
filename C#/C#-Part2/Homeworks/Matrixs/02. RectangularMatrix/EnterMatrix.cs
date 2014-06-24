using System;
using System.Linq;

class EnterMatrix
{
    static void Main()
    {
        int n = 0;
        int m = 0;
        do
        {
            Console.Write("Enter N: ");
            n = int.Parse(Console.ReadLine());
            Console.Write("Enter M: ");
            m = int.Parse(Console.ReadLine());

        } while (n<3 && m<3);
        Random randomNumber = new Random();
        int[,] arr = new int[n, m];
        int[] arrSum = new int[n * m];
        for (int row = 0; row < arr.GetLength(0); row++)
        {
            for (int col = 0; col < arr.GetLength(1); col++)
            {
                Console.Write("Row:{0}, Col:{1} = ",row, col);
                arr[row, col] = randomNumber.Next(20);
            }
        }
        Console.WriteLine();
        PrintMatrix(n, m, arr);
        int add = 0;
        for (int row = 0; row < n - 3; row++)
        {
            for (int col = 0; col < m - 3; col++)
            {
                Sums(arr, arrSum, add, row, col);
                add++;
            }
        }

        Console.WriteLine();
        Console.WriteLine(arrSum.Max());
    }

    private static void Sums(int[,] arr, int[] arrSum, int add, int row, int col)
    {
        for (int rowTwo = row; rowTwo < 3; rowTwo++)
        {
            for (int colTwo = col; colTwo < 3; colTwo++)
            {
                arrSum[add] += arr[rowTwo, colTwo];
            }
        }
    }

    private static void PrintMatrix(int n, int m, int[,] arr)
    {
        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < m; col++)
            {
                Console.Write("{0} ", arr[row, col]);
            }
            Console.WriteLine();
        }
    }
}

