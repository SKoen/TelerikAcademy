using System;

class FindAndPrint
{
    static void Main()
    {
        Console.Write("Enter N = ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter K = ");
        int k = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write("Array number {0} = ", i+1);
            arr[i] = int.Parse(Console.ReadLine());
        }

        Array.Sort(arr);
        Array.BinarySearch(arr, k, (x, y) =>
            {
                x = k;
                return x.CompareTo(y);
            });

        Console.WriteLine(k);
    }
}
