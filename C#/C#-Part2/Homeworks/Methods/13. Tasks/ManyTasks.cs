using System;

public class ManyTasks
{
    static void Main()
    {
        Console.WriteLine("Chouse the task:/nReverse the Digit(press 1)/nFind the Average(press 2)/nSolve the equation(press 3)");
        Console.WriteLine("Enter your choise: ");
        sbyte number = sbyte.Parse(Console.ReadLine());
        switch (number)
        {
            case 1: RvurseDigits();
                break;
            case 2: AvegareSequence();
                break;
            case 3: SolveEquation();
                break;
            default:Console.WriteLine("Not corect input!");
                break;
        }
    }
    public static void RvurseDigits()
    {
        Console.Write("Enter number: ");
        int number = int.Parse(Console.ReadLine());
        string length = number.ToString();
        int add = 0;
        for (int i = 0; i < length.Length; i++)
        {
            add = (int)number % 10;
            Console.Write(add);
            number /= 10;
        }
    }
    public static void AvegareSequence()
    {
        Console.Write("Enter the length of the Array: ");
        int length = int.Parse(Console.ReadLine());
        int[] arr = new int[length];
        PartOfArray.FullArray(arr);
        int average = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            average += arr[i];
        }
        average /= arr.Length;
    }
    public static void SolveEquation()
    {
        Console.Write("A = ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("B = ");
        int b = int.Parse(Console.ReadLine());
        double x = 0;
        if (a == 0 || b == 0)
        {
            Console.WriteLine("Error with the Input!");
        }
        else
        {
            x = a / -b;
            Console.WriteLine(x);
        }
    }
}
