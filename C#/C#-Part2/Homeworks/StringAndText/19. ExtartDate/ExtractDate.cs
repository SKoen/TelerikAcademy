using System;
using System.Globalization;
using System.Threading;

class ExtractDate
{
    static void Main()
    {
        string str = "I'm born in 6.10.1994 and know is 18.10.2014, from this time it was vary very booring...";
        char[] remove = { ' ', ',', '!', '?' };
        string[] strArr = str.Split(remove, StringSplitOptions.RemoveEmptyEntries);
        string[] dates = new string[strArr.Length];
        char[] find = { '.' };
        int add = 0;
        for (int i = 0; i < strArr.Length; i++)
        {
            if (strArr[i].IndexOfAny(find, 0, 2) > -1)
            {
                dates[add] = strArr[i];
                add++;
            }
        }
        Thread.CurrentThread.CurrentCulture = new CultureInfo("en-CA");
        foreach (var date in dates)
        {
            if (date != null)
            {
                Console.WriteLine(date);
            }
        }
    }
}
