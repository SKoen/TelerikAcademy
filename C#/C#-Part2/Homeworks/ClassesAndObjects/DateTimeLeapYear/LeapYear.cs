using System;

class LeapYear
{
    static void Main()
    {
        int year = int.Parse(Console.ReadLine());
        DateTime thime = new DateTime(year, 12,31);

        int day = thime.DayOfYear;
        if (day == 365)
        {
            Console.WriteLine("The year is Not Leap!");
        }
        else
        {
            Console.WriteLine("The year is Leap!");
        }
    }
}
