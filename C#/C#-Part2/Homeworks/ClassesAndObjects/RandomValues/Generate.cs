using System;

class Generate
{
    static void Main()
    {
        Random randomNumber = new Random();

        for (int i = 0; i < 10; i++)
        {
            Console.Write("{0}: ", i+1);
            Console.WriteLine(randomNumber.Next(100,201));
        }
    }
}
