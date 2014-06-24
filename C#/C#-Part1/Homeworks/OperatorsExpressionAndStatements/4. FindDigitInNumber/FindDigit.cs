using System;

class FindDigit
{
    static void Main()
    {
        int number = 1732;
        string digitString = number.ToString();
        char seven = '7';
        bool digit = digitString[1] == seven;
        Console.WriteLine(digit);
    }
}
