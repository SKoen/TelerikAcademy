using System;
using System.Text;
using System.Linq;

class FindLetters
{
    static void Main()
    {
        Console.Write("Enter string: ");
        string str = Console.ReadLine();
        char[] alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
        char[] lower = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
        int count = 0;
        StringBuilder strnew = new StringBuilder();
        for (int i = 0; i < alphabet.Length; i++)
        {
            count += str.Where(c => c == alphabet[i]).Count();
            count += str.Where(c => c == lower[i]).Count();
            strnew.AppendFormat("{0}: {1}\n", alphabet[i], count);
            count = 0;
        }
        Console.WriteLine(strnew.ToString());
    }
}
