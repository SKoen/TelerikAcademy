using System;

class Print
{
    static void Main()
    {
        Console.Write("Enter Lenth of the Array: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter the Number you want to search: ");
        int number = int.Parse(Console.ReadLine());
        int thimes = 0;
        int[] arr = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter {0} number in the Array: ", i+1);
            arr[i] = int.Parse(Console.ReadLine());
        }

        thimes = CountOfNumber(number, thimes, arr);
    }

    private static int CountOfNumber(int number, int thimes, int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (number == arr[i])
            {
                thimes++;
            }
        }
        Console.WriteLine("Number {0} shows {1} thimes!", number, thimes);
        return thimes;
    }
}

