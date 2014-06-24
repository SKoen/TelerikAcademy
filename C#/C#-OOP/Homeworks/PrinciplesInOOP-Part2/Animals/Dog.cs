using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Dog : Anumals
    {
        public Dog(string name, string sex, int age)
        {
            this.name = name;
            this.sex = sex;
            this.age = age;
        }

        public static void MakeSound()
        {
            Console.WriteLine("Jaf...");
        }
    }
}
