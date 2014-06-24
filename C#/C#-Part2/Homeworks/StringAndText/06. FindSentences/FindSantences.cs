using System;

class FindSantences
{
    static void Main()
    {
        Console.Write("Enter: ");
        string str = Console.ReadLine();
        string lookFor = " in ";
        char[] find = {'.'};
        string[] sentences = str.Split(find, StringSplitOptions.RemoveEmptyEntries);
        foreach (var sentenc in sentences)
        {
            if (sentenc.Contains(lookFor))
            {
                Console.WriteLine(sentenc);
            }
            
        }
    }
}
