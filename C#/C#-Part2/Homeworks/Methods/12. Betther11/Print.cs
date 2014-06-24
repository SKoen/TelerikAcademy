using System;

class AddSubMultPolynomials
{
    static void AddCoeff(int c1, int c2, int op, string[][] doubleArray)
    {
        int max = Math.Max(c1, c2);
        int min = Math.Min(c1, c2);
        double tem = 0;

        for (int i = 0; i < min; i++)
        {
            switch (op)
            {
                case 1:
                    tem = Convert.ToDouble(doubleArray[0][i]) + Convert.ToDouble(doubleArray[1][i]);
                    break;
                case 2:
                    tem = Convert.ToDouble(doubleArray[0][i]) - Convert.ToDouble(doubleArray[1][i]);
                    break;
                case 3:
                    tem = Convert.ToDouble(doubleArray[0][i]) * Convert.ToDouble(doubleArray[1][i]);
                    break;
            }
            doubleArray[2][i] = tem.ToString();
        }
        if (c1 == c2)
        {
            return;
        }
        else
        {
            if (c1 == max)
            {
                for (int i = min; i <= max; i++)
                {
                    tem = Convert.ToDouble(doubleArray[0][i]);
                    doubleArray[2][i] = tem.ToString();
                }
            }
            else if (c2 == max)
            {
                switch (op)
                {
                    case 1:
                        for (int i = min; i <= max; i++)
                        {
                            tem = (Convert.ToDouble(doubleArray[1][i]));
                            doubleArray[2][i] = tem.ToString();
                        }
                        break;
                    case 2:
                        for (int i = min; i <= max; i++)
                        {
                            tem = -(Convert.ToDouble(doubleArray[1][i]));
                            doubleArray[2][i] = tem.ToString();
                        }
                        break;
                    case 3:
                        for (int i = min; i <= max; i++)
                        {
                            doubleArray[2][i] = "0";
                        }
                        break;
                }
            }
        }
        return;
    }

    static void PrintPolynomial(int n, int row, string[][] jagget)
    {
        string str;
        if (n > 2)
        {
            str = ((jagget[row][0] == "0") ? "" : (jagget[row][0] + "X↑" + (n - 1)));
            Console.Write(str);
        }
        for (int i = 1; i < n - 2; i++)
        {
            str = (jagget[row][i] == "0") ? "" : (((Convert.ToDouble(jagget[row][i]) > 0) ? "+" : ""))
                 + jagget[row][i] + "X↑" + (n - i - 1);
            Console.Write(str);
        }
        str = (jagget[row][n - 2] == "0") ? "" : (((Convert.ToDouble(jagget[row][n - 2]) > 0) ? "+" : "")
             + jagget[row][n - 2] + "X");
        Console.Write(str);
        str = (jagget[row][n - 1] == "0") ? "" : (((Convert.ToDouble(jagget[row][n - 1]) > 0) ? "+" : "")
             + jagget[row][n - 1]);
        Console.WriteLine(str);
    }

    static void Main()
    {
        int n1, n2;
        string str;
        int oper = 1;

        do
        {
            Console.Write("Enter the operation: 1-addition, 2-subtraction, 3-multiplication: ");
        }
        while (!int.TryParse(str = Console.ReadLine(), out oper) || oper < 1 || oper > 3);
        do
        {
            Console.Write("Enter the length of the coefficients for polynomial1: ");
        }
        while (!int.TryParse(str = Console.ReadLine(), out n1) || n1 < 1);
        do
        {
            Console.Write("Enter the length of the coefficients for polynomial2: ");
        }
        while (!int.TryParse(str = Console.ReadLine(), out n2) || n2 < 1);

        int max = Math.Max(n1, n2);
        int min = Math.Min(n1, n2);
        string[][] jagged = new string[3][] { new string[n1 + 1], new string[n2 + 1], new string[max + 1] };

        Console.WriteLine("Enter the coefficients of the first polynomial, x0 coeff. having 0 index:");
        for (int i = 0; i < n1; i++)
        {
            jagged[0][i] = Console.ReadLine();
        }

        Console.WriteLine("Enter the coefficients of the first polynomial, x0 coeff. having 0 index:");
        for (int i = 0; i < n2; i++)
        {
            jagged[1][i] = Console.ReadLine();
        }

        jagged[2] = new string[max + 1];
        AddCoeff(n1, n2, oper, jagged);

        Array.Reverse(jagged[0], 0, n1);
        Console.Write("Polynomial1\t= ");
        PrintPolynomial(n1, 0, jagged);

        Array.Reverse(jagged[1], 0, n2);
        Console.Write("Polynomial2\t= ");
        PrintPolynomial(n2, 1, jagged);

        Array.Reverse(jagged[2], 0, max);
        Console.Write("Poly1 + Poly2\t= ");
        PrintPolynomial(max, 2, jagged);

    }
}