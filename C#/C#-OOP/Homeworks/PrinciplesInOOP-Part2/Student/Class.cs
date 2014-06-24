using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Student
{
    public class Class : Student
    {
        private string textIND;

        public string TextIdentifier
        {
            get
            {
                return this.textIND;
            }
            private set { }
        }
    }
}
