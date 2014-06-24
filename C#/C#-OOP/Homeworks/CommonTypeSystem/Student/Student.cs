namespace Student
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    class Student : ICloneable, IComparable
    {
        public string firstName;
        public string middleName;
        public string lastName;
        public string addres;
        public int ssn;
        public int mobilePhone;
        public string email;
        public int course;
        public Specialties specialy;
        public Universities university;
        public Faculties faculty;

        //public string FirstName { get { return this.firstName; } set { this.firstName = value; } }
        //public string LastName { get { return this.lastName; } set { this.lastName = value; } }
        //public string MiddleName { get { return this.middleName; } set { this.middleName = value; } }
        //public string Address { get { return this.addres; } set { this.addres = value; } }
        //public int SSN { get { return this.ssn; } set { this.ssn = value; } }
        //public int MobilePhone 
        //{
        //    get { return this.mobilePhone; } 
            
        //    set 
        //    {
        //        if (value.ToString().Length == 10)
        //        {
        //            this.mobilePhone = value;
        //        }
        //        else this.mobilePhone = 0;
        //    }
        //}
        //public string Email { get { return this.email; } set { this.email = value; } }
        //public int Course { get { return this.course; } set { this.course = value; } }
        //public Specialties Specialy { get { return this.specialy; } set { this.specialy = value; } }
        //public Universities University { get { return this.university; } set { this.university = value; } }
        //public Faculties Faculty { get { return this.faculty; } set { this.faculty = value; } }

        public override bool Equals(object obj)
        {
            Student student = obj as Student;
            if (student == null)
            {
                return false;
            }
            if (!Object.Equals(student.course, this.course))
            {
                return false;
            }
            if (!Object.Equals(student.specialy, this.specialy))
            {
                return false;
            }
            if (!Object.Equals(student.university, this.university))
            {
                return false;
            }
            if (!Object.Equals(student.faculty, this.faculty))
            {
                return false;
            }
            return true;
        }

        public override string ToString()
        {
            StringBuilder info = new StringBuilder();
            info.AppendFormat("Fist Name: {0}\n", firstName);
            info.AppendFormat("Middle Name: {0}\n", middleName);
            info.AppendFormat("Last Name: {0}\n", lastName);
            info.AppendFormat("Address: {0}\n", addres);
            info.AppendFormat("SSN: {0}\n", ssn);
            info.AppendFormat("Mobile Phone: {0}\n", mobilePhone);
            info.AppendFormat("E-mail: {0}\n", email);
            info.AppendFormat("Course: {0}\n", course);
            info.AppendFormat("Specialy: {0}\n", specialy);
            info.AppendFormat("University: {0}\n", university);
            info.AppendFormat("Faculty: {0}\n", faculty);
            return info.ToString();
        }

        public object Clone()
        {
            Student student = new Student();
            student.firstName = this.firstName;
            student.middleName = this.middleName;
            student.lastName = this.lastName;
            student.addres = this.addres;
            student.ssn = this.ssn;
            student.mobilePhone = this.mobilePhone;
            student.email = this.email;
            student.course = this.course;
            student.specialy = this.specialy;
            student.university = this.university;
            student.faculty = this.faculty;
            return student;
        }

        public int CompareTo(object obj)
        {
            Student student = obj as Student;
            if (student.firstName == this.firstName && student.middleName == this.middleName && student.firstName == this.lastName)
            {
                if (student.ssn == this.ssn)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
            else
            {
                return -1;
            } 
        }
    }
}
