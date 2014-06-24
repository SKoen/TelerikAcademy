using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Kitten : Cat
    {
        public Kitten(string name, int age)
        {
            this.name = name;
            this.sex = "Female";
            this.age = age;
        }
    }
}
