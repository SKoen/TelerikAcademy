using System;
using System.Collections.Generic;

class ExtractPolindromes
{
    static void Main()
    {
        string str = @"Just say LaiaL than. Againt aABBAa just for the record.";
        List<string> palindromes = new List<string>();

        string[] strArr = str.Split(GetPunctuation(), StringSplitOptions.RemoveEmptyEntries);

        for (int i = 0; i < strArr.Length; i++)
        {
            int length = strArr[i].Length;
            int halfLength = length / 2;
            int rsStartIndex = length - halfLength;
            string leftSide = strArr[i].Substring(0, halfLength);
            string rightSide = strArr[i].Substring(rsStartIndex, halfLength);
            char[] rightSideRevArr = rightSide.ToCharArray();
            Array.Reverse(rightSideRevArr);
            string rightSideRev = new string(rightSideRevArr);

            if (leftSide == rightSideRev)
            {
                palindromes.Add(strArr[i]);
            }
        }

        foreach (var item in palindromes)
        {
            Console.WriteLine(item);
        }
    }

    private static char[] GetPunctuation()
    {
        List<char> allPunctiation = new List<char>();

        for (int i = 0; i < 128; i++)
        {
            if (char.IsPunctuation((char)i))
            {
                allPunctiation.Add((char)i);
            }
        }
        allPunctiation.Add((char)32);
        return allPunctiation.ToArray();
    }
}