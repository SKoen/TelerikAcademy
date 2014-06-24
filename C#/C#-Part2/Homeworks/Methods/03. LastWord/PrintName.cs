using System;

class PrintName
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        FindLastDigit(number);
    }

    private static void FindLastDigit(int number)
    {
        int lastDigit = number % 10;

        switch (lastDigit)
        {
            case 1: Console.WriteLine("One");
                break;
            case 2: Console.WriteLine("Two");
                break;
            case 3: Console.WriteLine("Three");
                break;
            case 4: Console.WriteLine("Four");
                break;
            case 5: Console.WriteLine("Five");
                break;
            case 6: Console.WriteLine("Six");
                break;
            case 7: Console.WriteLine("Seven");
                break;
            case 8: Console.WriteLine("Eight");
                break;
            case 9: Console.WriteLine("Nine");
                break;
            default:
                break;
        }
    }
}
