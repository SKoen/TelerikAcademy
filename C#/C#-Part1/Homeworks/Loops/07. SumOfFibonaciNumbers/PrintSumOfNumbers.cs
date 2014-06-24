using System;
using System.Numerics;

class PrintSumOfNumbers
{
    static void Main()
    {
        Console.Write("Enter N = ");
        int n = int.Parse(Console.ReadLine());
        BigInteger first = 0;
        BigInteger second = 1;
        BigInteger thurd;
        BigInteger sum = 1;
        for (int i = 0; i < n-2; i++)
        {
            thurd = first + second;
            first = second;
            second = thurd;
            sum += thurd;
        }
        Console.WriteLine("Sum = " + sum);
    }
}
