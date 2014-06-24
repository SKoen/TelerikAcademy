using System;

class Finding
{
    static void Main()
    {
        int v = 5;
        int p = 1;

        int mask = 1 << p;
        int newMask = v & mask;
        int theBit = newMask >> p;
        bool truee = theBit == 1;
        Console.Write("Number = {0}\nMouving position = {1}\nAnd is that number 1: ", v, p);
        Console.WriteLine(truee);
    }
}
