using System;
using System.Text.RegularExpressions;
using System.Text;
using System.IO;
using System.Diagnostics;
using System.Collections.Generic;

class Remove
{
    static void Main()
    {
        string fileName = "input.txt";
        string resultFileName = "output.txt";
        Random rg = new Random();

        List<string> listOfWords = new List<string>(66);
        GenerateWords(listOfWords);

        StreamWriter enter = new StreamWriter(fileName, false, Encoding.GetEncoding("windows-1251"));
        using (enter)
        {
            for (int i = 0; i < 200; i++)
            {
                switch (rg.Next(5))
                {
                    case 0:
                        enter.Write(listOfWords[0]);
                        break;
                    case 1:
                        enter.Write(listOfWords[1]);
                        break;
                    case 2:
                        enter.Write(listOfWords[2]);
                        break;
                    default:
                        enter.Write(listOfWords[rg.Next(listOfWords.Count)]);
                        break;
                }
            }
        }

        enter = new StreamWriter(resultFileName, false, Encoding.GetEncoding("windows-1251"));
        StreamReader reader = new StreamReader(fileName, Encoding.GetEncoding("windows-1251"));
        using (enter)
        {
            using (reader)
            {
                string line = reader.ReadLine();
                while (line != null)
                {
                    line = Regex.Replace(line, @"(\b)test((\d|\w|_)*)(\b)", " ");
                    enter.WriteLine(Regex.Replace(line, @"(\s){2,}", " "));
                    line = reader.ReadLine();
                }
            }
        }
    }

    private static void GenerateWords(List<string> words)
    {
        words.Add("test");
        words.Add("\r\n");
        words.Add(" ");
        words.Add("_");
        for (int i = 48; i <= 57; i++)
        {
            words.Add(((char)i).ToString());
        }
        for (int i = 65; i <= 90; i++)
        {
            words.Add(((char)i).ToString());
        }
        for (int i = 97; i <= 122; i++)
        {
            words.Add(((char)i).ToString());
        }
    }
}