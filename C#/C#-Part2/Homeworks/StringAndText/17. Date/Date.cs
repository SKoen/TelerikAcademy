using System;
using System.Globalization;
using System.Threading;

class Date
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.Write("Enter date (day.month.year hour:minute:second): ");
        string datestr = Console.ReadLine();
        char[] remove = {' ', '.', ':'};
        string[] arr = datestr.Split(remove, StringSplitOptions.RemoveEmptyEntries);
        int[] datearr = new int[arr.Length];
        for (int i = 0; i < arr.Length; i++)
        {
            datearr[i] = Convert.ToInt32(arr[i]);
        }
        DateTime date = new DateTime(datearr[2], datearr[0], datearr[1], datearr[3], datearr[4], datearr[5]);
        Console.WriteLine("After 6:30 hours {0:d.MM.yyyy HH:mm:ss}", date.AddHours(6.5));
        Thread.CurrentThread.CurrentCulture = new CultureInfo("bg-BG");
        Console.WriteLine("Day: {0}", date.DayOfWeek);
    }
}
