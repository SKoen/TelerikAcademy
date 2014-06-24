using System;

class CheckBrackets
{
    static void Main()
    {
        Console.Write("Enter: ");
        string name = Console.ReadLine();
        int one = name.Split(')').Length;
        int two = name.Split('(').Length;

        if (one == two)
        {
            Console.WriteLine("Correct!");
        }
        else
        {
            Console.WriteLine("Not Correct!");
        }
    }
}
