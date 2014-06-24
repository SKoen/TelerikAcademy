using System;
using System.IO;

class Concatenates
{
    static void Main()
    {
        using (StreamWriter fileOut = new StreamWriter("nothing.txt"))
        {
            StreamReader fileOne = new StreamReader("123.txt");
            StreamReader fileTwo = new StreamReader("OddAndEven.txt");

            while (!fileOne.EndOfStream)
            {
                fileOut.WriteLine(fileOne.ReadLine() + fileTwo.ReadLine());
            }
        }
    }
}
