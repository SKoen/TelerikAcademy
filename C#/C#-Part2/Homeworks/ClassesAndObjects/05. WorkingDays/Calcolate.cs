using System;

class Calcolate
{
    static void Main()
    {
        DateTime now = DateTime.Now;
        Console.Write("Enter the date you want to know bigger than {0} (day, month, year): ", now);
        DateTime givenDate = DateTime.Parse(Console.ReadLine());
        Console.WriteLine(WorikingDays(givenDate, now));

    }
    public static int WorikingDays(DateTime dateTo, DateTime now)
    {
        int workingDays = 0;
        for (DateTime with = now; with < dateTo; with = with.AddDays(1))
        {
            if (with.DayOfWeek != DayOfWeek.Sunday && with.DayOfWeek != DayOfWeek.Saturday && Holidays(with) == 1)
            {
                workingDays++;
            }
        }

        return workingDays;
    }
    public static int Holidays(DateTime with)
    {
        int year = with.Year;
        DateTime[] arr = new DateTime[6];
        arr[0] = new DateTime(year, 12, 31);
        arr[1] = new DateTime(year, 1, 1);
        arr[2] = new DateTime(year, 3, 3);
        arr[3] = new DateTime(year, 11, 1);
        arr[4] = new DateTime(year, 12, 25);
        arr[5] = new DateTime(year, 9, 11);

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == with)
            {
                return 0;
            }
        }
        return 1;
    }
}

