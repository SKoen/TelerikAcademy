using System;

class Convertt
{
    static void Main()
    {
        string bin = Console.ReadLine();
        int squere = 0;
        double number = 0;
        for (int i = bin.Length-1; i >= 0; i--, squere++)
        {
            char that = bin[i];
            int num = Convert.ToInt32(that - '0');
            number += num * Math.Pow(2, squere);
        }
        Console.WriteLine("{0:0}", number);
    }
}
