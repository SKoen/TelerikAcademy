using System;
using System.IO;

    class Add
    {
        static void Main()
        {
            using (StreamWriter fileOut = new StreamWriter("Text.txt"))
            {
                int add = 1;
                StreamReader file = new StreamReader("OddAndEven.txt");
                while (!file.EndOfStream)
                {
                    Console.Write("{0:00} ", add);
                    Console.Write(file.ReadLine());
                    Console.WriteLine();
                    add++;
                }
            }
        }
    }
