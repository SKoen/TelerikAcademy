using System;

class PrintList
{
    static void Main()
    {
        Console.Write("Enter words: ");
        string str = Console.ReadLine();
        char[] remove = { ' ' };
        string[] strArr = str.Split(remove, StringSplitOptions.RemoveEmptyEntries);
        Array.Sort(strArr);
        foreach (var word in strArr)
        {
            Console.WriteLine(word);
        }
    }
}
