using System;

class GreatestValue
{
    static void Main()
    {
        Console.Write("Enter Number: ");
        int one = int.Parse(Console.ReadLine());
        Console.Write("Enter Number: ");
        int tow = int.Parse(Console.ReadLine());
        Console.Write("Enter Number: ");
        int three = int.Parse(Console.ReadLine());
        Console.Write("Enter Number: ");
        int four = int.Parse(Console.ReadLine());
        Console.Write("Enter Number: ");
        int five = int.Parse(Console.ReadLine());

        int[] arr = {one, tow, three, four, five};
        int bigger = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] > bigger)
            {
                bigger = arr[i];
            }
        }

        Console.WriteLine("The Biggest Number: {0}", bigger);
    }
}
