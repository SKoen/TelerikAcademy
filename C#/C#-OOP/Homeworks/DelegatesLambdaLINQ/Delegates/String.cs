using System;

namespace Delegates
{
    public delegate void StringBuilder(string text, int index, int length);

    public class String
    {
        public static void SubString(string text, int index, int length)
        {
            for (int i = index; i < length; i++)
            {
                Console.WriteLine(text[i]);
            }
        }
    }
}