using System;

class PrintForNnumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int min = int.MaxValue;
        int max = int.MinValue;
        int number;
        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter a Number: ");
            number = int.Parse(Console.ReadLine());
            if (number < min)
            {
                min = number;
            }
            if (number > max)
            {
                max = number;
            }
        }
        Console.WriteLine("Max Value = {0}\nMin Value = {1}", max, min);
    }
}
