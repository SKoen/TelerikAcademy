using System;

class SumOfSubset
{
    static void Main()
    {
        int[] arr = new int[5];
        int sum = 0;
        for(int i = 0; i < arr.Length; i++)
        {
        Console.Write("Enter a Number: ");
        arr[i] = int.Parse(Console.ReadLine());
        }

        for(int b = 0; b < arr.Length; b++)
        {
        for(int i = b; i < arr.Length; i++)
        {
	        sum += arr[i];
	        if(sum == 0)
	        {
		        Console.WriteLine("Sum is Zero");
                for (int v = b; v <= i; v++)
                {
                    if (v != i)
                    {
                        Console.Write(arr[v] + " + ");
                    }
                    else
                    {
                        Console.Write(arr[v]);
                    }
                }
                Console.WriteLine(" = 0");
	        }
        }
        sum = 0;
        }
    }
}
