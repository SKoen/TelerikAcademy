using System;

class PrintFor3And7
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        Console.Write("Numbers for One to N witch are not dividet on 3 and 7: ");
        for (int i = 1; i <= number; i++)
        {
            if (i % 3 != 0 || i % 7 != 0)
            {
                Console.Write(i + " ");
            }
        }
    }
}
