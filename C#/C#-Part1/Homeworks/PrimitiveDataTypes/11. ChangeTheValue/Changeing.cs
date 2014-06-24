using System;

class Changeing
{
    static void Main()
    {
        int five = 5;
        int ten = 10;
        int change;

        change = five;
        five = ten;
        ten = change;

        Console.WriteLine("Five = {0}\nTen = {1}", five, ten);
    }
}
