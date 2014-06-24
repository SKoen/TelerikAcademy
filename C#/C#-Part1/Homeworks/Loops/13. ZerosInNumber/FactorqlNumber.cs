using System;
using System.Numerics;

class FactorqlNumber
{
    static void Main()
    {
        Console.Write("Enter N = ");
        int n = int.Parse(Console.ReadLine());
        BigInteger nFak = 1;
        int zeros = 0;
        for (int i = 1; i <= n; i++)
        {
            nFak *= i;
        }

        while (nFak % 10 == 0)
        {
            zeros++;
            nFak /= 10;
        }
        Console.WriteLine("Zeros are: " + zeros);
    }
}
