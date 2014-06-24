using System;
using System.Text;

class Replace
{
    static void Main()
    {
        Console.WriteLine("Enter html code:");
        string html = Console.ReadLine();
        StringBuilder str = new StringBuilder(html);

        int index = -1;
        int indexUrl = 0;
        do
        {
            index = str.ToString().IndexOf("<a href=\"", index + 1);
            if (index == -1) break;
            indexUrl = str.ToString().IndexOf('"', index + 9);
            str.Replace("<a href=\"", "[URL=", index, 9);
            indexUrl -= 4;
            str.Replace("\">", "]", indexUrl, 2);

        } while (true);
        str.Replace("</a>", "[/URL]");
        Console.WriteLine("\nThe BBCODE output:\n{0}", str.ToString());
        Console.WriteLine();
    }
}