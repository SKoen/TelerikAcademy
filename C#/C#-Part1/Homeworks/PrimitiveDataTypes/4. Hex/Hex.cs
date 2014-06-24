using System;

class Hex
{
    static void Main()
    {
        char number = '\x00FE';
        int some = (char)number;
        Console.WriteLine(some);
    }
}

