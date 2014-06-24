using System;

class SubstringCounter
{
    static void Main()
    {
        Console.Write("Enter: ");
        string name = Console.ReadLine();
        string[] find = new string[1];
        Console.Write("Find: ");
        find[0] = Console.ReadLine();
        int counter = name.Split(find, StringSplitOptions.None).Length;
        Console.WriteLine("The result is {0}", counter);
   }
}
