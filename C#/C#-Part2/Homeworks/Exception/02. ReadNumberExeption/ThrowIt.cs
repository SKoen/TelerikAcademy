using System;

class ThrowIt
{
    static void Main()
    {
        int[] number = new int[10];
        for (int i = 0; i < 10; i++)
        {
           number[i] = ReadNumber(1, 1000);
           if (number[i] == 0)
           {
               throw new FormatException("Not currect, enter only numbers!");
           }
        }
    }

    public static int ReadNumber(int start, int end)
    {
        try
        {
            Console.WriteLine("Enter Number: ");
            int number = int.Parse(Console.ReadLine());
            return number;
        }
        catch (FormatException)
        {
            Console.WriteLine("Enter only numbers!");
        }
        return 0;
    }
}
