using System;

class Dictionary
{
    static void Main()
    {
        string[] dictionary = {".NET – platform for applications from Microsoft",
                                "CLR – managed execution environment for .NET",
                                "namespace – hierarchical organization of classes"};
        Console.Write("Enter Word (.NET, CLR, namespace): ");
        string word = Console.ReadLine();
        string desription = string.Empty;
        int from = 0;
        foreach (var type in dictionary)
        {
            if (type.Contains(word))
            {
                desription = type;
                break;
            }
        }
        from = desription.IndexOf('-', 0);
        Console.WriteLine(desription.Substring(from + 1, desription.Length - from));
    }
}
