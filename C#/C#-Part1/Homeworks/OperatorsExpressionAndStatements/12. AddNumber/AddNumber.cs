using System;

class AddNumber
{
    static void Main()
    {
        int n = 5;
        int p = 3;
        int v = 1;

        if (v == 1)
        {
            int mask = 1 << p;
            int result = n | mask;
            Console.WriteLine(result);
        }
        else
        {
            int mask = ~(1 << p);
            int result = n & mask;
            Console.WriteLine(result);
        }
    }
}
