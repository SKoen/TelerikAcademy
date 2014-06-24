using System;

class Triangle
{
    static void Main()
    {
        char symbol = '\u00A9';

        Console.WriteLine(symbol);
        Console.WriteLine("{0}{0}",symbol);
        Console.WriteLine("{0}{0}{0}",symbol);
        Console.WriteLine("{0}{0}",symbol);
        Console.WriteLine(symbol);
    }
}
