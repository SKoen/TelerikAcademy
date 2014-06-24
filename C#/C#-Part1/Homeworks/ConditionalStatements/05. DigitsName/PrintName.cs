using System;

class PrintName
{
    static void Main()
    {
        Console.Write("Enter ONE digit: ");
        char digit = char.Parse(Console.ReadLine());
        int digitTwo = Convert.ToInt32(digit - '0');
        switch (digitTwo)
        {
            case 0: Console.WriteLine("Zero");
                break;
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
            case 8: Console.WriteLine("Eith");
                break;
            case 9: Console.WriteLine("Nine");
                break;
            default: Console.WriteLine("That is not a digit");
                break;
        }
    }
}
