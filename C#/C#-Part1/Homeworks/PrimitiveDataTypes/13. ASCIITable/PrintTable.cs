using System;

class PrintTable
{
    static void Main()
    {
        int start = 0;
        while (start < 128)
        {
            Console.WriteLine((char)start);
            start++;
        }
    }
}