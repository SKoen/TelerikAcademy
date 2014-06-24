using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HumanProgram
{
    public class Student : Human
    {
        protected int grade;

        public int Grade
        {
            get { return this.grade; }
        }

        public Student(string fname, string lname, int grad)
        {
            this.firstName = fname;
            this.lastName = lname;
            this.grade = grad;
        }

        public override string ToString()
        {
            var information = firstName + " " + lastName + " " + grade.ToString();
            return information;
        }
    }
}
