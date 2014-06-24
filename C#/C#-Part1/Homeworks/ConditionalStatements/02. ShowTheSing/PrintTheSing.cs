using System;

class PrintTheSing
{
    static void Main()
    {
        Console.Write("Enter Number: ");
        int first = int.Parse(Console.ReadLine());
        Console.Write("Enter Number: ");
        int second = int.Parse(Console.ReadLine());
        Console.Write("Enter Number: ");
        int thurd = int.Parse(Console.ReadLine());

        Console.Write("The Numbers with there Sungs: ");
        if (first > 0)
        {
            Console.Write("+" + first);
        }
        else
        {
            Console.Write(" " + first);
        }
        if (second > 0)
        {
            Console.Write(" +" + second);
        }
        else
        {
            Console.Write(" " + second);
        }
        if (thurd > 0)
        {
            Console.Write(" +" + thurd);
        }
        else
        {
            Console.Write(" " + thurd);
        }
    }
}
