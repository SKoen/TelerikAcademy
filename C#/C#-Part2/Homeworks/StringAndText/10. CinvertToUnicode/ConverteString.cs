using System;
using System.Text;

class ConverteString
{
    static void Main()
    {
        Console.Write("Enter: ");
        string str = Console.ReadLine();
        byte[] unistr =Encoding.Unicode.GetBytes(str);
        string newstr = string.Empty;
        foreach (var digit in unistr)
        {
            if (digit != 0)
            {
                newstr = string.Format("{0}{1}", "\\u00", digit.ToString("X"));
                Console.WriteLine(newstr);
            }
           
        }
    }
}