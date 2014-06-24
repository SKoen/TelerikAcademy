using System;

class StringMatrix
{
    static void Main()
    {
        Console.Write("Enter the langth: ");
        int n = int.Parse(Console.ReadLine());
        string[,] arrString = new string[n,n];
        string[] place = { "bla", "HAHA", "Nqma", "Ela" };
        Random number = new Random();
        int rows = 0;
        int cols = 0;
        int diagonale = 0;
        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < n; col++)
            {
                arrString[row, col] = place[number.Next(3)];
            }
        }

        PrintMatrix(n, arrString);
        cols = CheckCols(n, arrString, cols);
        rows = CheckRows(n, arrString, rows);
        diagonale = CheckDiagonales(n, arrString, diagonale);

        Bigger(rows, cols, diagonale);
        
    }

    private static void Bigger(int rows, int cols, int diagonale)
    {
        if (cols > rows)
        {
            if (cols > diagonale)
            {
                Console.WriteLine("The largest is form Colons and it's {0} elements!", cols);
            }
            else
            {
                Console.WriteLine("The largest is form Diagonales and it's {0} elements!", diagonale);
            }
        }
        else if (diagonale > rows)
        {
            if (diagonale < cols)
            {
                Console.WriteLine("The largest is form Colons and it's {0} elements!", cols);
            }
            else
            {
                Console.WriteLine("The largest is form Diagonales and it's {0} elements!", diagonale);
            }
        }
        else
        {
            Console.WriteLine("The largest is form Rows and it's {0} elements!", rows);
        }
    }

    private static int CheckDiagonales(int n, string[,] arrString, int diagonale)
    {
        for (int row = 0; row < n; row++)
        {
            if (row == n - 1)
            {
                break;
            }
            int thimes = 1;
            for (int col = 0; col < n; col++)
            {
                if (col == n - 1)
                {
                    break;
                }
                if (arrString[row, col] == arrString[row + 1, col + 1])
                {
                    thimes++;
                }
                else
                {
                    break;
                }
            }
            if (diagonale < thimes)
            {
                diagonale = thimes;
            }
        }
        return diagonale;
    }

    private static int CheckRows(int n, string[,] arrString, int rows)
    {
        for (int col = 0; col < n; col++)
        {
            int thimes = 1;
            for (int row = 0; row < n; row++)
            {
                if (row == n - 1)
                {
                    break;
                }
                if (arrString[row, col] == arrString[row + 1, col])
                {
                    thimes++;
                }
                else
                {
                    break;
                }
            }
            if (rows < thimes)
            {
                rows = thimes;
            }
        }
        return rows;
    }

    private static int CheckCols(int n, string[,] arrString, int cols)
    {
        for (int row = 0; row < n; row++)
        {
            int thimes = 1;
            for (int cow = 0; cow < n; cow++)
            {
                if (cow == n-1)
                {
                    break;
                }
                if (arrString[row, cow] == arrString[row, cow + 1])
                {
                    thimes++;
                }
                else
                {
                    break;
                }
            }
            if (cols < thimes)
            {
                cols = thimes;
            }
        }
        return cols;
    }

    private static void PrintMatrix(int n, string[,] arrString)
    {
        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < n; col++)
            {
                Console.Write("{0} ", arrString[row, col]);
            }
            Console.WriteLine();
        }
    }

}
