using System;

class PrintResult
{
    static void Main()
    {
        //The Exam can be made with System.Numerics for bigger numbers!

        Console.Write("Enter K = ");
        int k = int.Parse(Console.ReadLine());
        Console.Write("Enter N (must be in interval 1 to K) = ");
        int n = int.Parse(Console.ReadLine());
        long nFak, kFak, knFak;
        nFak = 1;
        kFak = 1;
        knFak = 1;
        double sum = 0;
        if (n > 1 || n < k)
        {
            for (int i = 1; i <= n; i++)
            {
                nFak *= i;
            }
            for (int i = 1; i <= k; i++)
            {
                kFak *= i;
            }
            for (int i = 1; i <= k-n; i++)
            {
                knFak *= i;
            }
            sum = (nFak * kFak) / knFak;

            Console.WriteLine("N!*K! / (K-N)! = " + sum);
            
        }
        else
        {
            Console.WriteLine("N must be in interval 1 to K");
        }
    }
}
