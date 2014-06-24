using System;

public class PrintChecks
{
    public static void Main()
    {
        Console.Write("Enter position: ");
        int position = int.Parse(Console.ReadLine());
        Console.Write("Enter length of the Array: ");
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[5];

        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write("Enter {0} number of the Array: ", i+1);
            arr[i] = int.Parse(Console.ReadLine());
        }

        Check(position, arr);
    }

    public static void Check(int position, int[] arr)
    {
        if (position < arr.Length)
        {
            if (arr[position] > arr[position - 1] && arr[position] > arr[position + 1])
            {
                Console.WriteLine("Element on position {0} is bigger that his neigbors!", position);
            }
            else
            {
                Console.WriteLine("Element on position {0} is smoller that his neigbors!", position);
            }
        }
    }
}
