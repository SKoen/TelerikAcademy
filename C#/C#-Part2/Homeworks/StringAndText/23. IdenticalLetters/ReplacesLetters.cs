using System;
using System.Text;

class ReplacesLetters
{
    static void Main()
    {
        Console.Write("Enter string: ");
        string str = Console.ReadLine();
        StringBuilder newstr = new StringBuilder();
        string counts = string.Empty;
        while(str.Length > 0)
        {
            newstr.Append(str[0]);
            counts = str.TrimStart(str[0]);
            str = counts;
        }
         
        Console.WriteLine(newstr.ToString());
    }
}
