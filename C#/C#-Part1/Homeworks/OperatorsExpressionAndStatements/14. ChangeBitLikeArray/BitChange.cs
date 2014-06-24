using System;

class BitChange
{
    static void Main(string[] args)
    {
        
        int number = int.Parse(Console.ReadLine());
        byte positionOne = byte.Parse(Console.ReadLine());
        byte positionTwo = byte.Parse(Console.ReadLine());
        byte numOfExchange = byte.Parse(Console.ReadLine());
 
        int maskFirstPosition = 0;
        for (int i = positionOne + numOfExchange - 1; i >= positionOne; i--)
        {
                maskFirstPosition = maskFirstPosition | ((int)1 << i);
        }

        Console.WriteLine("Mask of P: {0:X8}", maskFirstPosition);
        int maskSecondPosition = 0;

        for (int i = positionTwo + numOfExchange - 1; i >= positionTwo; i--)
        {
            maskSecondPosition = maskSecondPosition | ((int)1 << i);
        }

        Console.WriteLine("Mask of Q: {0:X8}", maskSecondPosition);
        int resultMask = ~(maskFirstPosition | maskSecondPosition);
        Console.WriteLine("Mask of results: {0:X8}", resultMask);
        int bitsFirstPosition = number & maskFirstPosition;
        int bitsSecondPosition = number & maskSecondPosition;
        int resultNumber;

        if (positionOne < positionTwo)
        {
                resultNumber = (number & resultMask) | (bitsFirstPosition << positionTwo | bitsSecondPosition >> positionTwo);
        }
        else
        {
                resultNumber = (number & resultMask) | (bitsFirstPosition >> positionOne | bitsSecondPosition << positionOne);
        }
 
        Console.WriteLine("The resulting number after exchanging bits is {0}", resultNumber);
    }
}
