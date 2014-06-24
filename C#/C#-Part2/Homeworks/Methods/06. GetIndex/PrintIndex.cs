using System;

public class PrintIndex
{
    static void Main()
    {
        Console.Write("Enter length of the Array: ");
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[5];

        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write("Enter {0} number of the Array: ", i + 1);
            arr[i] = int.Parse(Console.ReadLine());
        }
        int number = GetIndex(arr);
        Console.WriteLine(number);
    }
    public static int GetIndex(int[] arr)
    {
        for (int i = 1; i < arr.Length; i++)
        {
            if (i == arr.Length-1)
            {
                break;
            }
            if (arr[i] > arr[i-1] && arr[i] > arr[i+1])
            {
                return i;
            }
        }
        return -1;
    }
}

