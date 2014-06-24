using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public class Anumals
    {
        protected int age;
        protected string name;
        protected string sex;
        public int Age { get { return this.age; } set { this.age = value; } }
        public string Name { get { return this.name; } set { this.name = value; } }
        public string Sex { get { return this.sex; } set { this.sex = value; } }

    }
}
