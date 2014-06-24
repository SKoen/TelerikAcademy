using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main()
    {
        List<string> list = new List<string>();
        using (StreamReader file = new StreamReader("Bla.txt"))
        {
            string word = null;
            string text = file.ReadToEnd();
            for (int i = 0; i < text.Length; i++)
            {
                if (i == text.Length-1) break;
                if (text[i] == '>' && text[i+1] != '<')
                {
                    for (int l = i+1; text[l] != '<'; l++)
                    {
                        if (l == text.Length - 1) break;
                        word += text[l];
                    }
                    list.Add(word);
                    word = null;
                }
            }
        }

        foreach (var item in list)
        {
            Console.Write(item);
        }
    }
}
