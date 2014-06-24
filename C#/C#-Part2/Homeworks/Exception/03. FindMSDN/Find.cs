using System;

namespace Exceptions
{
    class Exercise03
    {
        static void Main()
        {
            Console.Write("Enter file name:");
            try
            {
                Console.WriteLine(System.IO.File.ReadAllText(Console.ReadLine()));
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception caught!\n{0}:{1}", e.GetType().Name, e.Message);
            }
        }
    }
}