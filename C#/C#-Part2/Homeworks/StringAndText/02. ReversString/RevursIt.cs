using System;
using System.Text;

class RevursIt
{
    static void Main()
    {
        Console.Write("Enter Some String: ");
        string name = Console.ReadLine();
        StringBuilder newName = new StringBuilder();
        for (int i = name.Length-1; i >= 0; i--)
        {
            newName.Append(name[i]);
        }
        Console.WriteLine(newName.ToString());
    }
}
