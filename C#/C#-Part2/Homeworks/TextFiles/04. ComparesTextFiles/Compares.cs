using System;
using System.IO;

class Compares
{
    static void Main()
    {
        int equalRows = 0;
        int diferentRows = 0;
        using (StreamReader fileOne = new StreamReader("OddAndEven.txt"))
        {
            StreamReader fileTwo = new StreamReader("OddAndEvenTwo.txt");

            while (!fileOne.EndOfStream)
            {
                if (fileOne.ReadLine() == fileTwo.ReadLine())
                {
                    equalRows++;
                }
                else
                {
                    diferentRows++;
                }
            }
        }
        Console.WriteLine("Equal Rows = {0}\nDiferent Rows = {1}", equalRows, diferentRows);
    }
}
