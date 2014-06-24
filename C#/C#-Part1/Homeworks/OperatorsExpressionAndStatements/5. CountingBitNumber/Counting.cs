using System;

class Counting
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        int mouving = 3;
        Console.Write("The number binary format is: ");
        Console.WriteLine(Convert.ToString(number,2));
        int mask = 1 << mouving;
        int newMask = number & mask;
        int theBit = newMask >> mouving;
        Console.WriteLine("The number on the position 3 is: {0}", theBit);

    }
}
