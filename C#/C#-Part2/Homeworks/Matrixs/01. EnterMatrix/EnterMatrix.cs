using System;

public class EnterMatrix
{
    static void Main()
    {
        // If you want to start the program delite the "//" infront of one "add" and star it!

        int n = int.Parse(Console.ReadLine());
        int[,] arr = new int[n, n];
        int add = 0;
        //add = EnterMatrixA(n, arr, add);  
        //add = EnterMatrixB(n, arr, add);
        //add = EnterMatrixC(n, arr, add);

        PrintMatrix(n, arr);
    }

    private static int EnterMatrixC(int n, int[,] arr, int add)
    {
        add = 1;
        arr[n - 1, 0] = add;
        for (int row = n - 2; row >= 0; row--)
        {
            int down = row;
            for (int col = 0; col < n; col++, down++)
            {
                if (down == n)
                {
                    break;
                }
                arr[down, col] = ++add;
            }
        }
        for (int col = 1; col < n; col++)
        {
            int down = col;
            for (int row = 0; row < n; row++, down++)
            {
                if (down == n)
                {
                    break;
                }
                arr[row, down] = ++add;
            }
        }
        return add;
    }

    private static int EnterMatrixB(int n, int[,] arr, int add)
    {
        int thime = 1;
        for (int row = 0; row < n; row++)
        {
            if (thime % 2 != 0)
            {
                for (int col = 0; col < n; col++)
                {
                    arr[col, row] = ++add;
                }
            }
            else
            {
                for (int col = n - 1; col >= 0; col--)
                {
                    arr[col, row] = ++add;
                }
            }
            thime++;
        }
        return add;
    }

    private static int EnterMatrixA(int n, int[,] arr, int add)
    {
        for (int col = 0; col < n; col++)
        {
            for (int row = 0; row < n; row++)
            {
                arr[row, col] = ++add;
            }
        }
        return add;
    }

    private static void PrintMatrix(int n, int[,] arr)
    {
        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < n; col++)
            {
                Console.Write("{0} ", arr[row, col]);
            }
            Console.WriteLine();
        }
    }
}

