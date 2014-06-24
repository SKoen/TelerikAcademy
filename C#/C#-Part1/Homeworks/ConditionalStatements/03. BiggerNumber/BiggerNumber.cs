using System;

class BiggerNumber
{
    static void Main()
    {
        Console.Write("Enter Number: ");
        int firstNumber = int.Parse(Console.ReadLine());
        Console.Write("Enter Number: ");
        int secondNumber = int.Parse(Console.ReadLine());
        Console.Write("Enter Number: ");
        int thurdNumber = int.Parse(Console.ReadLine());

        if (firstNumber > secondNumber)
        {
            if (firstNumber > thurdNumber)
            {
                Console.WriteLine(firstNumber);
            }
            else
            {
                Console.WriteLine(thurdNumber);
            }
        }
        else
        {
            if (secondNumber > thurdNumber)
            {
                Console.WriteLine(secondNumber);
            }
            else
            {
                Console.WriteLine(thurdNumber);
            }
        }
    }
}
