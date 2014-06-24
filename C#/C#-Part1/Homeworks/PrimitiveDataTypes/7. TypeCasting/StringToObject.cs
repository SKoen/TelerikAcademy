using System;

class StringToObject
{
    static void Main()
    {
        string hello = "Hello";
        string world = "World";

        object objectValue = hello + " " + world;

        string newValue = objectValue.ToString();

        Console.WriteLine(newValue + "!");
    }
}
