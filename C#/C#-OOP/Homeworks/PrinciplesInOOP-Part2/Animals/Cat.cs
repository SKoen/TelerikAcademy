using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public class Cat : Anumals
    {
        public Cat(string name, string sex, int age)
        {
            this.name = name;
            this.sex = sex;
            this.age = age;
        }

        public Cat()
        {
        }

        public static void MakeSound()
        {
            Console.WriteLine("Miooo...");
        }
    }
}
