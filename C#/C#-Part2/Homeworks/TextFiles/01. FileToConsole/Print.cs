using System;
using System.IO;

class Print
{
    static void Main()
    {
        using (StreamReader file = new StreamReader("OddAndEven.txt"))
        {
            do
            {
                Console.WriteLine(file.ReadLine());
            }
            while (file.ReadLine() != null);
        }
    }
}
