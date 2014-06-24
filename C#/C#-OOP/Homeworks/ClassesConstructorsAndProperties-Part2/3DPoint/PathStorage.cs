using System;
using System.IO;

namespace ThreeDPoint
{
    static class PathStorage
    {
        public static string text;
        public static string alltext;

        static void ToFile()
        {
            using (StreamWriter file = new StreamWriter(text))
            {
                file.WriteLine("");
            }
        }

        static void FromFile()
        {
            using (StreamReader fileTwo = new StreamReader(text))
            {
                alltext = fileTwo.ReadToEnd();
            }
        }
        
    }
}
