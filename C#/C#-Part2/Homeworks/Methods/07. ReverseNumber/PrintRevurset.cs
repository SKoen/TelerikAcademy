using System;

class PrintRevurset
{
    static void Main()
    {
        decimal number = decimal.Parse(Console.ReadLine());
        number = ReverseNumber(number);
    }

    private static decimal ReverseNumber(decimal number)
    {
        string length = number.ToString();
        int add = 0;
        for (int i = 0; i < length.Length; i++)
        {
            add = (int)number % 10;
            Console.Write(add);
            number /= 10;
        }
        Console.WriteLine();
        return number;
    }
}
