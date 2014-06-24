using System;

class PrintValue
{
    static void Main()
    {
        Console.Write("For int enter 1, for double enter 2 and for string enter 3: ");
        string startNumber = Console.ReadLine();
        byte choise;
        bool check = byte.TryParse(startNumber, out choise);
        bool CorrectInput;

        if (check)
        {
            switch (choise)
            {
                case 1:
                    Console.Write("Enter your int variable: ");
                    long intChoice;
                    CorrectInput = long.TryParse(Console.ReadLine(), out intChoice);
                    if (CorrectInput)
                    {
                        Console.WriteLine(intChoice + 1);
                    }
                    else
                    {
                        Console.WriteLine("Incorrect input! Please Try again!");
                        Main();
                    }
                    break;
                case 2:
                    Console.Write("Enter your double variable: ");
                    double doubleChoice;
                    CorrectInput = double.TryParse(Console.ReadLine(), out doubleChoice);
                    if (CorrectInput)
                    {
                        Console.WriteLine(doubleChoice + 1.0);
                    }
                    else
                    {
                        Console.WriteLine("Incorrect input! Please Try again!");
                        Main();
                    }
                    break;
                case 3:
                    Console.Write("Enter your string variable: ");
                    string strChoice = Console.ReadLine();
                    Console.WriteLine(strChoice + "*");
                    break;
                default:
                    Console.WriteLine("Incorrect input! Please Try again!");
                    Main();
                    break;
            }
        }
        else
        {
            Console.WriteLine("Incorrect input! Please Try again!");
            Main();
        }
    }
}
