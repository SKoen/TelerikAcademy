using System;
using System.Collections.Generic;
using System.Linq;

class Convertt
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        int rest = 0;
        List<char> list = new List<char>();
        while (number > 0)
        {
            rest = number % 16;
            if (rest > 9)
            {
                switch (rest)
                {
                    case 10: list.Add('A');
                        break;
                    case 11: list.Add('B');
                        break;
                    case 12: list.Add('C');
                        break;
                    case 13: list.Add('D');
                        break;
                    case 14: list.Add('E');
                        break;
                    case 15: list.Add('F');
                        break;
                    default:
                        break;
                }
            }
            else
            {
                char add = Convert.ToChar(rest + '0');
                list.Add(add);
            }
            number /= 16;
        }
        PrintArray(list);
    }
    static void PrintArray(List<char> arr)
    {
        for (int i = arr.Count - 1; i >= 0; i--)
        {
            Console.Write(arr[i]);
        }
        Console.WriteLine();
    }
}
