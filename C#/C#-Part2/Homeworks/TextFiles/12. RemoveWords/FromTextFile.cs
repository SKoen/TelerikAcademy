using System;
using System.Collections.Generic;
using System.IO;

class FromTextFile
{
    static void Main()
    {
        string file = "words.txt";
        string remove = "remove.txt";
        List<string> listOfWords = new List<string>();
        RemoveWords(remove, listOfWords);
        RemoveWordFile(file, listOfWords);

    }

    public static void RemoveWords(string remove, List<string> listOfWords)
    {
        using (StreamReader fileHelp = new StreamReader(remove))
        {
            while (!fileHelp.EndOfStream)
            {
                string newArr = fileHelp.ReadLine();
                listOfWords.Add(newArr);
            }
        }
    }

    public static void RemoveWordFile(string file, List<string> listOfWords)
    {
        string line = null;
        int i;

        try
        {
            using (StreamReader fileOne = new StreamReader(file))
            {
                using (StreamWriter fileChange = new StreamWriter("wordstow.txt"))
                {
                    while ((line = fileOne.ReadLine()) != null)
                    {
                        for (i = 0; i < listOfWords.Count; i++)
                        {
                            if (line == listOfWords[i])
                            {
                                fileChange.WriteLine("\n");
                                break;
                            }
                        }
                        if (line != listOfWords[i - 1])
                        {
                            fileChange.WriteLine(fileOne.ReadLine());
                        }

                    }
                }
            }
        }
        catch (FileNotFoundException e)
        {
            Console.WriteLine(e.Message);
        }

        catch (DirectoryNotFoundException e)
        {
            Console.WriteLine(e.Message);
        }

        catch (IOException e)
        {
            Console.WriteLine(e.Message);
        }

        catch (UnauthorizedAccessException e)
        {
            Console.WriteLine(e.Message);
        }
    }
}
        
