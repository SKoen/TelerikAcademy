using System;

class ForSet
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        PartOfArray.FullArray(arr);
        int min = Minimum(arr);
        int max = Max(arr);
        int average = Average(arr);
        int sum = Sum(arr);
        long product = Product(arr);

        Console.WriteLine("Min Value is: {0}\nMax Value is: {1}\nAverage is: {2}\nSum is: {3}\nProduct is: {4}", min, max, average, sum, product);
    }
    static int Minimum(int[] arr)
    {
        int min = int.MaxValue;
        for (int i = 0; i < arr.Length; i++)
        {
            if (min > arr[i])
            {
                min = arr[i];
            }
        }
        return min;
    }
    static int Max(int[] arr)
    {
        int max = int.MinValue;
        for (int i = 0; i < arr.Length; i++)
        {
            if (max < arr[i])
            {
                max = arr[i];
            }
        }
        return max;
    }
    static int Average(int[] arr)
    {
        int average = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            average += arr[i];
        }
        average /= arr.Length;
        return average;
    }
    static int Sum(int[] arr)
    {
        int sum = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            sum += arr[i];
        }
        return sum;
    }
    static long Product(int[] arr)
    {
        long product = 1;
        for (int i = 0; i < arr.Length; i++)
        {
            product *= arr[i];
        }
        return product;
    }
}
