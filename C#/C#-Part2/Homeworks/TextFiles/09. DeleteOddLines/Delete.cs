using System;
using System.IO;

class Delete
{
    static void Main()
    {
        using (StreamWriter newfile = new StreamWriter("Without.txt"))
        {
            StreamReader file = new StreamReader("WithOddLines.txt");
            for (int i = 0; !file.EndOfStream ; i++)
            {
                if (i%2!=0)
                {
                    newfile.WriteLine(file.ReadLine());
                }
                else
                {
                    newfile.WriteLine("\n");
                    file.ReadLine();
                }
            }
        }

    }
}
