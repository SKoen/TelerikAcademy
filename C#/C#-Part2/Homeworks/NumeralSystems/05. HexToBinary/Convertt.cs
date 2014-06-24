using System;

class Convertt
{
    static void Main()
    {
        string hex = Console.ReadLine();
        ConvertHexToBinary(hex);
    }
    static void ConvertHexToBinary(string input)
    {
        int len = input.Length;
        int bin = 0;
        int count = 0;
        for (int i = len - 1; i >= 0; i--, count++)
        {
            switch (input[i])
            {
                case 'A': bin = bin | (10 << 4 * count); break;
                case 'B': bin = bin | (11 << 4 * count); break;
                case 'C': bin = bin | (12 << 4 * count); break;
                case 'D': bin = bin | (13 << 4 * count); break;
                case 'E': bin = bin | (14 << 4 * count); break;
                case 'F': bin = bin | (15 << 4 * count); break;
                default: bin = bin | ((input[i] - 48) << 4 * count); break;
            }
        }
        Console.WriteLine(Convert.ToString(bin, 2).PadLeft(32, '0'));
    }
}