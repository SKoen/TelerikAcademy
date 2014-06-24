using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Student
{
    public class Disciplines
    {
        private string name;
        private int numberLection;
        private int numberExercises;

        public string Name
        { 
            get 
            { 
                return this.name; 
            } 
            private set { } 
        }

        public int NumberLec 
        {
            get
            {
                return this.numberLection;
            }
            private set { }
        }

        public int NumberExercises
        {
            get
            {
                return this.numberExercises;
            }
            private set { }
        }
    }
}
