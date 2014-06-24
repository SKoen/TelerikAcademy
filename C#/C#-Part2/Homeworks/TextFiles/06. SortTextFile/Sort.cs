using System;
using System.Collections.Generic;
using System.IO;

class Sort
{
    static void Main()
    {
        Console.Write("Enter file you want to sort: ");
        string file = Console.ReadLine();
        Console.Write("Enter file you want to safe the sorted text: ");
        string fileTwo = Console.ReadLine();
        SortFile(file, fileTwo);
        Console.WriteLine("Done!!!");
    }

    public static void SortFile(string file, string fileTwo)
    {
        List<string> listOfWords = new List<string>();
        using (StreamReader fileChange = new StreamReader(file))
        {
            while (!fileChange.EndOfStream)
            {
                string newArr = fileChange.ReadLine();
                listOfWords.Add(newArr);
            }
        }
        listOfWords.Sort();
        using (StreamWriter filee = new StreamWriter(fileTwo))
        {
            foreach (var item in listOfWords)
            {
                filee.WriteLine(item);
            }
        }
    }
}

