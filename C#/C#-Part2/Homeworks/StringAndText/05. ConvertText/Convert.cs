using System;
using System.Text.RegularExpressions;

class Convert
{
    static void Main()
    {
        string name = "We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.";
        string newname = Regex.Replace(name, "<upcase>(.*?)</upcase>", m => m.Groups[1].Value.ToUpper());
        Console.WriteLine(newname);
    }
}
