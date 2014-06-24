using System;
using System.Collections.Generic;
using System.IO;

class Change
{
    static void Main()
    {

        using (StreamWriter file = new StreamWriter("Second.txt"))
        {
            StreamReader filetwo = new StreamReader("First.txt");
            while (!filetwo.EndOfStream)
            {
                string bla = filetwo.ReadLine();
                string blatow = bla.Replace("Start", "finish");
                file.WriteLine(blatow);
            }
        }

        
    }

    //public static void MakeList()
    //{
        //List<string> list = new List<string>();
        //list.Add("Start to play!");
        //list.Add("Start to Grow!");
        //list.ToArray();
        //using (StreamWriter file = new StreamWriter("First.txt"))
        //{
        //    int add = 0;
        //    for (int i = 0; i < 40000; i++)
        //    {
        //        file.WriteLine(list[add]);
        //        if (add == 1)
        //        {
        //            add = 0;
        //        }
        //        add++;
        //    }
        //}
    //}
}
