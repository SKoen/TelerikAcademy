using System;

class Checks
{
    static void Main()
    {
        int x = int.Parse(Console.ReadLine());
        int y = int.Parse(Console.ReadLine());

        bool circl = (x > 1.1 && x < 3 && y > 1.1 && y < 3);
        bool rectangle = ((x > 6 && y > 2) || (y > 6 && x > 2));

        if (circl)
        {
            Console.WriteLine("It's in the Circle!");
        }
        if (rectangle)
        {
            Console.WriteLine("It's out the Rectangle");
        }
    }
}
