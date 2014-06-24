using System;

class StringInfo
{
    static void Main()
    {
        Console.WriteLine("String is a Array of Chars with lot of Methods: ");
        string word = "word";
        int index = word.IndexOf('o');
        Console.WriteLine("1. IndexOf get the index of the given char or string Example (Search 'o' in Word): {0}", index);
        Console.WriteLine("2. Conatains is the method that serach in the string for char or other string (return -1 or 0)");
        Console.WriteLine("3. Substring is the method that give us the part of the string we want Example (in word we want to get 'rd').");
        Console.WriteLine("4. Split is the mothod that broke the string in the place we want Example (we give '>' and when it see it broke it).");
    }
}

