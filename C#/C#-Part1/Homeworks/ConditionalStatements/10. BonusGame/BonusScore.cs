using System;

class BonusScore
{
    static void Main()
    {
        Console.Write("Enter a Bonus Number from 1 to 10: ");
        int number = int.Parse(Console.ReadLine());

        switch (number)
        {
            case 1:
            case 2:
            case 3: number *= 10;
                Console.WriteLine("The Bonus is: " + number);
                break;
            case 4:
            case 5:
            case 6: number *= 100;
                Console.WriteLine("The Bonus is: " + number);
                break;
            case 7:
            case 8:
            case 9: number *= 1000;
                Console.WriteLine("The Bonus is: " + number);
                break;
            default: Console.WriteLine("Error");
                break;
        }
    }
}
