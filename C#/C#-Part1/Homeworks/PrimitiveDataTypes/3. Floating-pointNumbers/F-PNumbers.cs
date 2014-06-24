using System;

class Program
{
    static void Main()
    {
        float number = 5.0000001f;
        float numberTwo = 5.00000003f;
        Console.WriteLine(Math.Abs(number - numberTwo) <= float.Epsilon);
    }
}

