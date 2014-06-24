using System;

class ToText
{
    static void Main()
    {
        Console.Write("Enter a Number (from 0 to 999) = ");
        int number = int.Parse(Console.ReadLine());
        string digits = number.ToString();
        string[] names = new string[digits.Length];
        char[] digitChar = new char[digits.Length];

        for (int i = 0; i < digits.Length; i++)
        {
            digitChar[i] = digits[i];
        }

        for (int l = 0; l < digits.Length; l++)
        {
            switch (digitChar[l])
            {
                case '0': names[l] = "Zero";
                    break;
                case '1': names[l] = "One";
                    break;
                case '2': names[l] = "Two";
                    break;
                case '3': names[l] = "Three";
                    break;
                case '4': names[l] = "Four";
                    break;
                case '5': names[l] = "Five";
                    break;
                case '6': names[l] = "Six";
                    break;
                case '7': names[l] = "Seven";
                    break;
                case '8': names[l] = "Eidth";
                    break;
                case '9': names[l] = "Nine";
                    break;
                default: names[l] = "NO";
                    break;
            }
        }

        if (digits.Length > 2)
        {
            if (digitChar[1] == '0')
            {
                Console.WriteLine("{0} hundred and {1}", names[0], names[2]);
            }
            else
            {
                Console.WriteLine("{0} hundred {1} {2}", names[0], names[1], names[2]);
            }
        }
        else if (digits.Length > 1)
        {
            Console.WriteLine("{0}ty {1}", names[0], names[1]);
        }
        else if (digits.Length == 1)
        {
            Console.WriteLine(names[0]);
        }
    }
}
