using System;
using System.Collections.Generic;

class Representation
{
    static void Main()
    {
        decimal number = decimal.Parse(Console.ReadLine());
        long byn = Convert.ToInt32(number);
        List<int> numberss = new List<int>();
        while (byn > 0)
        {
            int that = (int)byn % 2;
            numberss.Add(that);
            byn /= 2;
        }
        
        PrintArray(numberss);
    }
    static void PrintArray(List<int> arr)
    {
        for (int i = arr.Count-1; i >= 0; i--)
        {
            Console.Write(arr[i]);
        }
        Console.WriteLine();
    }
}

