using System;

class SumOfString
{
    static void Main()
    {
        Console.Write("Emter string of numbers: ");
        string numbers = Console.ReadLine();
        Console.WriteLine(SumOfStringNumbers(numbers));

    }
    private static int SumOfStringNumbers(string number)
    {

        int result = 0;
        string adding = "";
        int addnumber;
        char geting;
        for (int i = 0; i <= number.Length; i++)
        {
            if (i < number.Length)
            {
                geting = number[i];
                if (geting != 32)
                {
                    adding += geting;
                }
                else
                {
                    addnumber = Convert.ToInt32(adding);
                    result += addnumber;
                    adding = "";
                }
            }
            else
            {
                addnumber = Convert.ToInt32(adding);
                result += addnumber;
            }
            
        }

        return result;
    }
}
