using System;

class PrintSorting
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
                Console.Write(firstNumber + " ");
                if (secondNumber > thurdNumber)
                {
                    Console.Write(secondNumber + " " + thurdNumber);
                }
                else
                {
                    Console.Write(thurdNumber + " " + secondNumber);
                }
            }
        }
        if (secondNumber > firstNumber)
        {
            if (secondNumber > thurdNumber)
            {
                Console.Write(secondNumber + " ");
                if (firstNumber > thurdNumber)
                {
                    Console.Write(firstNumber + " " + thurdNumber);
                }
                else
	            {
                    Console.Write(thurdNumber + " " + secondNumber);
	            }
            }
            
        }
        if(thurdNumber > firstNumber)
        {
            if (thurdNumber > secondNumber)
            {
                Console.Write(thurdNumber + " ");
                if (secondNumber > firstNumber)
                {
                    Console.Write(secondNumber + " " + firstNumber);
                }
                else
                {
                    Console.Write(firstNumber + " " + secondNumber);
                }
            }
        }
        Console.WriteLine();
    }
}
