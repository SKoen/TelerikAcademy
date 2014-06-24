using System;

class ReplaceWords
{
    static void Main()
    {
        Console.Write("Enter: ");
        string str = Console.ReadLine();
        string[] badwords = { "PHP", "CLR", "Microsoft" };
        string full;
        foreach (var word in badwords)
        {
            full = new string('*', word.Length);
            str = str.Replace(word, full);
        }
        Console.WriteLine(str);
    }
}
