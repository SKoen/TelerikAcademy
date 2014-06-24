using System;

class EuclideanAlgorithm
{
    static void Main()
    {
        Console.Write("Enter Number: ");
        int firstNumber = int.Parse(Console.ReadLine());
        Console.Write("Enter Number: ");
        int secondNumber = int.Parse(Console.ReadLine());
        int firstDel, secondDel, gcd;
        gcd = 0;
        string first = firstNumber.ToString();
        string second = secondNumber.ToString();
        char one = first[2];
        one -= '0';
        char two = second[2];
        two -= '0';
        firstDel = Convert.ToInt32(one);
        secondDel = Convert.ToInt32(two);

        if (firstNumber > secondNumber)
        {
            gcd = (secondDel * secondNumber) + ((-firstDel) * firstNumber);
        }
        else if (secondNumber > firstNumber)
        {
            gcd = ((-secondDel) * secondNumber) + (firstDel * firstNumber);
        }

        Console.WriteLine("GTC = " + gcd);
    }
}
