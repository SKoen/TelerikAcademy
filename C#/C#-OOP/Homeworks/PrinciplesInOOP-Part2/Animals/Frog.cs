using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Frog : Anumals
    {
        public Frog(string name, string sex, int age)
        {
            this.name = name;
            this.sex = sex;
            this.age = age;
        }

        public Frog(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public static void MakeSound()
        {
            Console.WriteLine("Cvack...");
        }
    }
}
