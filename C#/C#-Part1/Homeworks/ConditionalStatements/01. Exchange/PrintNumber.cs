using System;

class PrintNumber
{
    static void Main()
    {
        Console.Write("Enter Number: ");
        int number = int.Parse(Console.ReadLine());
        Console.Write("Enter Number: ");
        int numberTwo = int.Parse(Console.ReadLine());

        if (number > numberTwo)
        {
            numberTwo = number;
            Console.WriteLine("The First is bigger and Now the second is: {0}", numberTwo);
        }
        else
        {
            Console.WriteLine("The First is smoller and it is: {0}", number);
            Console.WriteLine("The Second is: {0}", numberTwo);
        }
    }
}
