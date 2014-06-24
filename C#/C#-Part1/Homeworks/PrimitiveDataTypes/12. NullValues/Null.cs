using System;

class Null
{
    static void Main()
    {
        string first = null;
        string second = null;
        int firstNull = Convert.ToInt32(first, 10);
        double socondNull = Convert.ToDouble(second, 10);

        Console.WriteLine(firstNull);
        Console.WriteLine(socondNull);
    }
}
