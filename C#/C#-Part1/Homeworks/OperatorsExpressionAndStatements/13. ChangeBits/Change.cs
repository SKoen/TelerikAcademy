using System;

class Change
{
    static void Main()
    {
        Console.WriteLine("Enter number to modify: ");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine("Bitwise representation of number is: {0}", Convert.ToString(number, 2).PadLeft(32, '0'));
        int positionOne = 3;
        int positionTwo = 24;
        int countofpos = 6;
        int mask = 1;

        int bitFirstPosition = 0;
        int bitSecondPosition = 0;
        int tempOne = 0;
        while (positionOne < countofpos)
        {
            bitFirstPosition = number & (mask << positionOne);        
            bitFirstPosition = bitFirstPosition >> positionOne;
            bitSecondPosition = number & (mask << positionTwo);
            bitSecondPosition = bitSecondPosition >> positionTwo;
            tempOne = bitFirstPosition;
            bitFirstPosition = bitSecondPosition;
            bitSecondPosition = tempOne;
            if (bitFirstPosition != bitSecondPosition)
            {
                if (bitFirstPosition == 1)
                {
                    bitSecondPosition = bitFirstPosition;
                    number = number | (bitFirstPosition << positionOne);
                    number = number & ~(bitSecondPosition << positionTwo);
                }
                else
                {
                    bitFirstPosition = bitSecondPosition;
                    number = number & ~(bitFirstPosition << positionOne);
                    number = number | (bitSecondPosition << positionTwo);
                }
            }
            else
            {

            }
            positionOne++;
            positionTwo++;
        }
        Console.WriteLine(number);
        Console.WriteLine("Bitwise new representation of number is : {0}", Convert.ToString(number, 2).PadLeft(32, '0'));
    }
}
