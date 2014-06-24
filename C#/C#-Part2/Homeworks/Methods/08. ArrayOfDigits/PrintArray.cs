using System;

public class PrintArray
{
    public static void Main()
    {
        ulong number = ulong.Parse(Console.ReadLine());
        string digits = number.ToString();
        int[] arr = new int[digits.Length];
        MakeDigits(number, arr);
        PrintArrayy(arr);
    }

    public static void MakeDigits(ulong number, int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = (int)number % 10;
            number /= 10;
        }
    }
    public static void PrintArrayy(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i] + " ");
        }
        Console.WriteLine();
    }
}

