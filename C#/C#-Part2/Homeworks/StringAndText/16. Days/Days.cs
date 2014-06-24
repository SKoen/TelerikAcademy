using System;

class Days
{
    static void Main()
    {
        Console.Write("Enter start date (day.month.year): ");
        DateTime start = DateTime.Parse(Console.ReadLine());
        Console.Write("Enter end date (day.month.year): ");
        DateTime end = DateTime.Parse(Console.ReadLine());
        int daysOfMonth = DateTime.DaysInMonth(start.Year, start.Month);
        daysOfMonth -= start.Day;
        daysOfMonth += end.Day;
        Console.WriteLine("Distance: {0} days", daysOfMonth);
        
    }
}
