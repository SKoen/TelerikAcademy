using System;

public class PartOfArray
{
    public static void Main()
    {
        Console.Write("Enter the langt of the Array: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter the strat Index: ");
        int index = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        FullArray(arr);
        int maxNumber = MaxElement(index, arr);
        Console.WriteLine(maxNumber);
        SortArr(arr);
        PrintArray.PrintArrayy(arr);
    }
    public static void FullArray(int[] arr)
    {
        Random number = new Random();
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = number.Next(1, 10);
        }
    }
    public static int MaxElement(int index, int[] arr)
    {
        int max = arr[index];
        for (int i = index+1; i < arr.Length; i++)
        {
            if (max < arr[i])
            {
                max = arr[i];
            }
        }
        return max;
    }
    public static void SortArr(int[] arr)
    {
        int[] arrTwo = new int[arr.Length];
        for (int i = 0; i < arr.Length; i++)
        {
            arrTwo[i] = int.MaxValue;
            for (int l = i; l < arr.Length; l++)
            {
                if (arrTwo[i] > arr[l])
                {
                    arrTwo[i] = arr[l];
                }
            }
        }
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = arrTwo[i];
        }
    }
}

