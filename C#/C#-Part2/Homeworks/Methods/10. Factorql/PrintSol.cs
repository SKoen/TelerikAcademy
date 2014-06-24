using System;

class PrintSol
{
    static void Main()
    {
        int n;
        do
        {
            n = int.Parse(Console.ReadLine()); 
        } while (n < 1 && n > 100);
        int[] arr = new int[n];
        MultiNumbers(arr);
            
    }

    private static void MultiNumbers(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = 1;
            for (int l = i+1; l > 0; l--)
            {
                arr[i] *= l;
            }
            Console.WriteLine(arr[i]);
        }
    }
}
