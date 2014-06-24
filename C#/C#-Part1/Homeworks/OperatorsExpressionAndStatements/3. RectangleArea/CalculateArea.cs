using System;

class CalculateArea
{
    static void Main()
    {
        Console.Write("Wight = ");
        double widht = double.Parse(Console.ReadLine());
        Console.Write("Height = ");
        double height = double.Parse(Console.ReadLine());

        double area = widht * height;

        Console.WriteLine("The Area = {0}", area);
    }
}
