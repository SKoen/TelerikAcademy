using System;

class Convertt
{
    static void Main()
    {
        string hex = Console.ReadLine();
        int squere = 0;
        int rest = 0;
        double number = 0;
        for (int i = hex.Length-1; i >= 0; i--, squere++)
        {
            if (hex[i] >= 'A' && hex[i] <= 'F')
            {
                switch (hex[i])
                {
                    case 'A': rest = 10;
                        break;
                    case 'B': rest = 11;
                        break;
                    case 'C': rest = 12;
                        break;
                    case 'D': rest = 13;
                        break;
                    case 'E': rest = 14;
                        break;
                    case 'F': rest = 15;
                        break;
                    default:
                        break;
                }
            }
            else if (hex[i] >= '1' && hex[i] <= '9')
            {
                rest = Convert.ToInt32(hex[i] - '0');
            }
            number += rest * Math.Pow(16, squere);
        }
        Console.WriteLine(number);
    }
}
