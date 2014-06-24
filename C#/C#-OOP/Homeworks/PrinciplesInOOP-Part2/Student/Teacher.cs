using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Student
{
    public class Teacher : Disciplines, IPeople
    {
        public string name;

        public string TeacherName
        {
            get
            {
                return this.name;
            }
            set
            {
                if (this.name.Length < 30)
                {
                    this.name = value;
                }
                else
                {
                    this.name = "No Name!";
                }
                
            }
        }

        public void PrintName()
        {
            Console.WriteLine("My name is " + this.name);
        }
    }
}
