using System;

class PrintForNK
{
    static void Main()
    {
        Console.Write("Enter N = ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter K (must be in interval 1 to N) = ");
        int k = int.Parse(Console.ReadLine());
        long nFak, kFak;
        double sum = 0;
        nFak = 1;
        kFak = 1;
        if (k > 1 || k < n)
        {
            for (int i = 1; i <= n; i++)
            {
                nFak *= i;
            }
            for (int i = 1; i <= k; i++)
            {
                kFak *= i;
            }

            sum = nFak / kFak;
            Console.WriteLine("N!/K! = " + sum);
        }
        else
        {
            Console.WriteLine("K must be in interval 1 to N");
        }
    }
}

