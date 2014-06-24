namespace Student
{
    using System;
    using System.Collections.Generic;
    using System.Collections;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Person
    {
        public string name;
        public int? age;

        public int? Age
        {
            get { return this.age;}
            set { this.age = value;}
        }

        public override string ToString()
        {
            return "Name:" + this.name + "\nAge: {1}" + this.age;
        }
    }
}
