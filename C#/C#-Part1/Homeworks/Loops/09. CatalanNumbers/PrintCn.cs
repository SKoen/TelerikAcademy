using System;
using System.Numerics;

class PrintCn
{
    static void Main()
    {
        Console.Write("Enter N (n need to be bigger ot eqal to 0) = ");
        int n = int.Parse(Console.ReadLine());
        BigInteger twoN = 1;
        BigInteger nPlus = 1;
        BigInteger nFak = 1;
        BigInteger c = 0;
        for (int i = 1; i <= n*2; i++)
        {
            twoN *= i;
        }
        for (int i = 1; i <= n+1; i++)
        {
            nPlus *= i;
        }
        for (int i = 1; i <= n; i++)
        {
            nFak *= i;
        }

        c = twoN / (nPlus * nFak);
        Console.WriteLine("Cn = " + c);
    }
}
