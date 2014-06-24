using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace EX13CountWordsInFile
{
    class EX13CountWordsInFile
    {
        static void Main()
        {
            string fileSourcePath = "test.txt";
            string fileResultPath = "output.txt";
            string fileDictionaryPath = "words.txt";

            Dictionary<string, int> listOfWords = new Dictionary<string, int>();

            try
            {
                using (StreamReader reader = new StreamReader(fileDictionaryPath, Encoding.GetEncoding("utf-8")))
                {
                    while (!reader.EndOfStream)
                    {
                        string word = reader.ReadLine();
                        listOfWords.Add(word, 0);
                    }
                }

                using (StreamReader reader = new StreamReader(fileSourcePath, Encoding.GetEncoding("utf-8")))
                {
                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();

                        List<string> wordList = new List<string>(listOfWords.Keys);

                        foreach (string word in wordList)
                        {
                            string regex = String.Format("\\b{0}\\b", word);
                            MatchCollection matches = Regex.Matches(line, regex);
                            listOfWords[word] += matches.Count;
                        }
                    }
                }

                using (StreamWriter writer = new StreamWriter(fileResultPath, false, Encoding.GetEncoding("utf-8")))
                {
                    foreach (var wordCounter in listOfWords.OrderByDescending(key => key.Value))
                    {
                        writer.Write(wordCounter.Key);
                        writer.Write("-");
                        writer.WriteLine(wordCounter.Value);
                    }
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine("io operation error!");
                Console.WriteLine(ex.Message);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("error while trying to count word!");
                Console.WriteLine(ex.Message);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("error while trying to count word!");
                Console.WriteLine(ex.Message);
            }
            catch (RegexMatchTimeoutException ex)
            {
                Console.WriteLine("error while trying to count word!");
                Console.WriteLine(ex.Message);
            }
        }
    }
}