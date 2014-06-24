using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateSurface
{
    class Rectangle : Shape
    {
        public virtual void PrintR()
        {
            Console.WriteLine("Rectangle!");
        }

        public override int CalculateSurface()
        {
            return height * width;
        }
    }
}
