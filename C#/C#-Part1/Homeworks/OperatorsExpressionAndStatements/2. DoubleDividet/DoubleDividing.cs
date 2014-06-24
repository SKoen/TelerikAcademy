using System;

class DoubleDividing
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        bool dividedNumber = (number % 7 == 0 && number % 5 == 0);

        if (dividedNumber)
        {
            Console.WriteLine("{0} can be divided by 5 and 7", number);
        }
        else
        {
            Console.WriteLine("{0} can't be divided", number);
        }
    }
}
