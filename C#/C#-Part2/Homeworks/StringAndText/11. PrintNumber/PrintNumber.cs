using System;

class PrintNumber
{
    static void Main()
    {
        Console.Write("Enter Number: ");
        decimal number = decimal.Parse(Console.ReadLine());
        Console.Write("{0:D}, {0:X}, ",(int)Math.Round(number, 0));
        Console.Write("{0:P}, {0:E}", number);
        Console.WriteLine();
    }
}
