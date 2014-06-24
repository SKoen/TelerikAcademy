using System;

class Sort
{
    static void Main()
    {
        Console.Write("Enter lengt of the Array: ");
        int n = int.Parse(Console.ReadLine());
        string[] stringArr = new string[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter {0} word: ", i+1);
            stringArr[i] = Console.ReadLine();
        }

        Array.Sort(stringArr, (x,y) =>
        {
            int lengtOne = x.Length;
            int lengtTwo = y.Length;

            return lengtOne.CompareTo(lengtTwo);
        });

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(stringArr[i]);
        }
    }
}
