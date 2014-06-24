using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

class MaxSum
{
    static void Main()
    {
        int thimes = 0;
        int add = 0;
        int[,] arr =  EnterMatrixFile();
        int[] arrSum = new int[2 * arr.GetLength(0)];
        for (int row = 0; row < arr.GetLength(0) - 2; row++)
        {
            for (int col = 0; col < arr.GetLength(0) - 2; col++)
            {
                Sums(arr, arrSum, add, row, col);
                add++;
            }
        }

        Console.WriteLine(arrSum.Max());
    }

    public static int[,] EnterMatrixFile()
    {
        string allthext = null;
        using (StreamReader file = new StreamReader("matrix.txt"))
        {
            allthext = file.ReadToEnd();
        }
        char[] remove = new char[] {'\r', '\n', ' '};
        string[] arrNumbers = allthext.Split(remove, StringSplitOptions.RemoveEmptyEntries);
        int strat = Convert.ToInt32(arrNumbers[0]);
        int[,] arr = new int[strat, strat];
        int move = 1;
        for (int row = 0; row < strat; row++)
        {
            for (int col = 0; col < strat; col++)
            {
                int newnumber = Convert.ToInt32(arrNumbers[move]);
                arr[row, col] = newnumber;
                move++;
            }
        }
        return arr;
    }

    private static void Sums(int[,] arr, int[] arrSum, int add, int row, int col)
    {
        for (int rowTwo = row; rowTwo < 2; rowTwo++)
        {
            for (int colTwo = col; colTwo < 2; colTwo++)
            {
                arrSum[add] += arr[rowTwo, colTwo];
            }
        }
    }
}
