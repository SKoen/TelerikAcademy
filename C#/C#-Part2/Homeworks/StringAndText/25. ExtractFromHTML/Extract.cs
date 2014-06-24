using System;
using System.IO;

class Extract
{
    static void Main()
    {
        string text, title, body = string.Empty;
        using (StreamReader str = new StreamReader("index.html"))
        {
            text = str.ReadToEnd();
            title = Title(text);
            int inde = text.IndexOf("<body>");
            text = text.Substring(inde + 6);
            for (int i = 0; i < text.Length; i++)
            {
                if (i == text.Length - 1) break;
                if (text[i] == '>' && text[i+1] != '<')
                {
                    int index = text.IndexOf('<', i);
                    if (text.Substring(i, index - i).Contains("\n")) continue;
                    else
                    {
                        body += text.Substring(i, index-i);
                    }
                }
            }
            Console.WriteLine(body);
        }
    }

    private static string Title(string text)
    {
        string title;
        if (text.Contains("title"))
        {
            int index = text.IndexOf("title");
            int indexTwo = text.LastIndexOf("title");
            int get = indexTwo - (index + 8);
            title = text.Substring(index + 6, get);
        }
        else
        {
            title = "No Title!";
        }
        return title;
    }
}
