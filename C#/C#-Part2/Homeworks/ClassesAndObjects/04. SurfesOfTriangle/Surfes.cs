using System;

class Surfes
{
    static void Main()
    {
        Console.WriteLine(SurfesOfTriangle());
    }
    private static int SurfesOfTriangle()
    {
        Console.WriteLine("What do you want to add:");
        Console.WriteLine("1. Side and Altitude.");
        Console.WriteLine("2. Three Sides.");
        Console.WriteLine("3. Two Sides and an angle betwen them.");
        Console.Write("Choise (1, 2 or 3): ");
        int typeOfAdd = int.Parse(Console.ReadLine());
        if (typeOfAdd == 1)
        {
            int s = SideAndAltitude();
            return s;
        }
        else if (typeOfAdd == 2)
        {
            int s = ThreeSides();
            return s;
        }
        else if (typeOfAdd == 3)
        {
            int s = TwoSidesAndAngle();
            return s;
        }
        else
        {
            Console.WriteLine("Enter another number (1, 2 or 3)!");
        }

        return 0;
    }

    private static int ThreeSides()
    {
        Console.Write("Enter Side: ");
        int side = int.Parse(Console.ReadLine());
        Console.Write("Enter Side: ");
        int sidetwo = int.Parse(Console.ReadLine());
        Console.Write("Enter Side: ");
        int sidethree = int.Parse(Console.ReadLine());
        int p = (side + sidethree + sidetwo) / 2;
        double sfirst = Math.Sqrt(p*(p - side) * (p - sidetwo) * (p - sidethree));
        int s = (int)sfirst;
        return s;
    }

    private static int TwoSidesAndAngle()
    {
        Console.Write("Enter Side: ");
        int side = int.Parse(Console.ReadLine());
        Console.Write("Enter Side: ");
        int sidetwo = int.Parse(Console.ReadLine());
        Console.Write("Enter angle: ");
        double angle = int.Parse(Console.ReadLine());
        double sdouble = side * side * Math.Sin(angle) / 2;
        int s = (int)sdouble;
        return s;
    }

    private static int SideAndAltitude()
    {
        Console.Write("Enter Side: ");
        int side = int.Parse(Console.ReadLine());
        Console.Write("Enter Altitude: ");
        int altitude = int.Parse(Console.ReadLine());
        int s = 0;

        s = altitude * side / 2;
        return s;
    }
}

