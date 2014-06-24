using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HumanProgram
{
    public class Worker : Human
    {
        private int selary;
        private int hourPerDay;

        public int WeekSelary
        {
            get
            {
                return this.selary;
            }
            set
            {
                this.selary = value;
            }
        }

        public int WorkHoursPerDay
        {
            get
            {
                return this.hourPerDay;
            }
            set
            {
                this.hourPerDay = value;
            }
        }

        public int MoneyPerHour()
        {
            var money = this.selary * this.hourPerDay;
            return money;
        }

        public Worker(string fname, string lname, int money, int hour)
        {
            this.firstName = fname;
            this.lastName = lname;
            this.hourPerDay = hour;
            this.selary = money;
        }

        public override string ToString()
        {
            var information = firstName + " " + lastName + " " + MoneyPerHour().ToString();
            return information;
        }
    }
}
