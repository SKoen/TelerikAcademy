using System;

class Find
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[,] arr = new int[n,n];
        Random number = new Random();

        for (int row = 0; row < arr.GetLength(0); row++)
        {
            for (int col = 0; col < arr.GetLength(1); col++)
            {
                arr[row, col] = number.Next(1, 5);
            }
        }

        PrintMatrix(arr);


    }

    private static void PrintMatrix(int[,] arrString)
    {
        for (int row = 0; row < arrString.GetLength(0); row++)
        {
            for (int col = 0; col < arrString.GetLength(1); col++)
            {
                Console.Write("{0} ", arrString[row, col]);
            }
            Console.WriteLine();
        }
    }
    
}
