using System;

class GetEmails
{
    static void Main()
    {
        string str = "From pesho@abv.bg we write a mesage to iliq@gmail.com and than we see that we sendet it to shasho@mail.bg.";
        char[] remove = {' '};
        string[] strArr = str.Split(remove, StringSplitOptions.RemoveEmptyEntries);

        foreach (var word in strArr)
        {
            if (word.Contains("@"))
            {
                Console.WriteLine(word);
            }
        }
    }
}

