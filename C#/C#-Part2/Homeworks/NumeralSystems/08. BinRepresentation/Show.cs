using System;

class Show
{
    static void Main()
    {
        short number = short.Parse(Console.ReadLine());
        int[] arr = new int[16];

        for (int index = 0; index < arr.Length; index++)
        {
            if (number > 0)
            {
                arr[index] = number % 2;
                number /= 2;
            }
            else
            {
                arr[index] = 0;
            }
        }
        Array.Reverse(arr);
        PrintArray(arr);

    }
    static void PrintArray(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i]);
        }
        Console.WriteLine();
    }
}
