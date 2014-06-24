using System;

class ChecksCircle
{
    static void Main()
    {
        int x = 3;
        int y = 2;

        bool contanCircle = (x > 0 && x < 5 && y > 0 && y < 5);

        Console.WriteLine("{0} and {1} can containt in that circl?: {2}", x, y, contanCircle);
    }
}
