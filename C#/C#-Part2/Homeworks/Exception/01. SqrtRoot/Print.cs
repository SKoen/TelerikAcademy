using System;

class Print
{
    static void Main()
    {
        try
        {
            Console.Write("Enter a Number: ");
            int n = int.Parse(Console.ReadLine());
            if (n < 0)
            {
                throw new FormatException("Invalid amount!");
            }
            double sqrt = Math.Sqrt(n);
            Console.WriteLine("Sqrt of {0} is {1}", n, sqrt);
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid number");
        }
        finally
        {
            Console.WriteLine("Good bye");
        }
    }
}
