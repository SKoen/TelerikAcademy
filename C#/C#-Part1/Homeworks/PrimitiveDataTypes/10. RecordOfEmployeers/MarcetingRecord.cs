using System;

class MarcetingRecord
{
    static void Main()
    {
        Console.Write("First Name: ");
        string firstName = Console.ReadLine();
        Console.Write("Family Name: ");
        string familyName = Console.ReadLine();
        Console.Write("Age: ");
        byte age = byte.Parse(Console.ReadLine());
        Console.Write("Ganter (m/f): ");
        char ganter = char.Parse(Console.ReadLine());
        Console.Write("ID: ");
        int id = int.Parse(Console.ReadLine());
        Console.Write("Employee Number: ");
        long emplNumber = long.Parse(Console.ReadLine());
    }
}
