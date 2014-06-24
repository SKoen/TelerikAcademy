using System;

class PrintSum
{
    static void Main()
    {
        Console.Write("Enter N = ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter X = ");
        int x = int.Parse(Console.ReadLine());
        double sum = 1;
        long nFak = 1;
        long xPow = 1;
        for (int i = 1; i <= n; i++)
        {
            nFak *= i;
            xPow *= x;
            sum += nFak / xPow;
        }

        Console.WriteLine("S = {0:0.00}",sum);
    }
}
