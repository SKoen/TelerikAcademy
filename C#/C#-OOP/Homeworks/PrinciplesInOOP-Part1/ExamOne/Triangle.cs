using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateSurface
{
    class Triangle : Shape
    {
        public virtual void PrintT()
        {
            Console.WriteLine("Teiangle!");
        }

        public override int CalculateSurface()
        {
            return (height * width)/2;
        }
    }
}
