using System;

class OddOrEven
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        bool even = number % 2 == 0;

        if (even)
        {
            Console.WriteLine("{0} is Even", number);
        }
        else
        {
            Console.WriteLine("{0} is Odd", number);
        }
    }
}
