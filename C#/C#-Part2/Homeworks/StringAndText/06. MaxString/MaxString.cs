using System;

class MaxString
{
    static void Main()
    {
        Console.Write("Enter: ");
        string str = Console.ReadLine();
        int langth = 19 - str.Length;
        string sometinh = new string('*', langth);
        str = string.Concat(str, sometinh);
        Console.WriteLine(str);
    }
}
