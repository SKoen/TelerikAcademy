using System;

class Check
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        if (n % 2 != 0 && n % 3 != 0 && n % 5 != 0 && n % 7 != 0 && n % 11 != 0 && n % 13 != 0 && n % 17 != 0)
        {
            Console.WriteLine("{0} is Prime!", n);
        }
        else if (n == 2 || n == 3 || n == 5 || n == 7 || n == 13 || n == 17)
        {
            Console.WriteLine("{0} is Prime!", n);
        }
        else
        {
            Console.WriteLine("{0} is not a prime Number", n);
        }
    }
}
