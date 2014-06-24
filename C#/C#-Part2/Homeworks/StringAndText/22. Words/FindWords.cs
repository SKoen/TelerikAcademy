using System;
using System.Text;
using System.Text.RegularExpressions;

class FindWords
{
    static void Main()
    {
        Console.Write("Enter string: ");
        string str = Console.ReadLine();
        char[] remove = { ' ', '.', ',', '!', '?' };
        string[] words = str.Split(remove, StringSplitOptions.RemoveEmptyEntries);
        int count;
        StringBuilder newstr = new StringBuilder();
        foreach (var word in words)
        {
            count = Regex.Matches(str, word).Count;
            newstr.AppendFormat("{0}: {1}\n", word, count);
            count = 0;
        }
        Console.WriteLine(newstr.ToString());
    }
}
