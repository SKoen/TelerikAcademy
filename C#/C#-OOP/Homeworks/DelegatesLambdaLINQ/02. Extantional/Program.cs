using System;
using System.Collections.Generic;

namespace _02.Extantional
{
    public delegate void WorkWithNumbers<T>(T value, T valueTwo);
     
    class Numbers<T> 
    where T: IEnumerable<T>
    {
        public static void Sum<T>(T value, T valueTwo)
        {
            Console.WriteLine(value.ToString() + valueTwo.ToString());
        }

        public static void Product<T>(T value, T valueTwo)
        {
            Console.WriteLine(value.ToString() + valueTwo.ToString());
        }


    }
}