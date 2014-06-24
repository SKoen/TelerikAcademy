using System;
using System.Text;

class ReverseWords
{
    static void Main()
    {
        Console.Write("Enter URL: ");
        string str = Console.ReadLine();
        char[] remove = { ' ', ',', '.', '!', '?',};
        string[] strArr = str.Split(remove, StringSplitOptions.RemoveEmptyEntries);
        string[] sinds = str.Split(strArr, StringSplitOptions.None);
        StringBuilder newstr = new StringBuilder();
        for (int i = strArr.Length-1; i >= 0 ; i--)
        {
            newstr.Append(strArr[i] + sinds[i]);
        }
        Console.WriteLine(newstr.ToString());
    }
}
