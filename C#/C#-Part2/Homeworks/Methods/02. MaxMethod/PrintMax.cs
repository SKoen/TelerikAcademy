using System;

class PrintMax
{
    static void Main()
    {
        int first = int.Parse(Console.ReadLine());
        int second = int.Parse(Console.ReadLine());
        int thurd = int.Parse(Console.ReadLine());

        GetMax(first, second, thurd);
    }

    private static void GetMax(int first, int second, int thurd)
    {
        if (first > second)
        {
            if (first > thurd)
            {
                Console.WriteLine(first);
            }
            else
            {
                Console.WriteLine(thurd);
            }
        }
        else
        {
            if (second > thurd)
            {
                Console.WriteLine(second);
            }
            else
            {
                Console.WriteLine(thurd);
            }
        }
    }
}
