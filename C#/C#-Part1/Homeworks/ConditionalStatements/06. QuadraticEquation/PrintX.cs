using System;

class PrintX
{
    static void Main()
    {
        double d, x, x1, x2;
        Console.Write("Enter A: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Enter B: ");
        int b = int.Parse(Console.ReadLine());
        Console.Write("Enter C: ");
        int c = int.Parse(Console.ReadLine());

        if (a != 0 && b != 0 && c != 0)
        {
            d = (-b) * (-b) - 4 * a * c;

            x1 = (-b + Math.Sqrt(d)) / 2 * a;
            x2 = (-b - Math.Sqrt(d)) / 2 * a;
            Console.WriteLine("X1 = {0:0.00}\nX2 = {1:0.00}", x1, x2);
        }
        else if (a == 0)
        {
            x = -c / b;
            Console.WriteLine("X = " + x);
        }
        else if (b == 0)
        {
            x = Math.Sqrt(-c / a);
            Console.WriteLine("X = " + x);
        }
        else if(c == 0)
        {
            x1 = 0;
            x2 = -b / a;
            Console.WriteLine("X1 = {0:0.00}\nX2 = {1:0.00}", x1, x2);
        }
        else
        {
            Console.WriteLine("Not a real ROOTS!!!");
        }
    }
}
