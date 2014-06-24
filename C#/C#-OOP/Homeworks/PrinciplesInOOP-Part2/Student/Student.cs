using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Student
{
    public class Student : Teacher, IPeople
    {
        public string name;
        private int classNumber;

        public string Name
        {
            get
            {
                var namelang = 30;
                if (namelang > this.name.Length)
                {
                    return this.name;
                }
                else
                {
                    return "No name!";
                }
            }
            set
            {
                this.name = value;
            }
        }

        public int ClassNumber
        {
            get
            {
                return this.classNumber;
            }
            private set { }
        }

        public void PrintName()
        {
            Console.WriteLine("My name is " + this.name);
        }
    }
}
