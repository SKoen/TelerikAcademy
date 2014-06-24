using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateSurface
{
    class Circle : Shape
    {
        public Circle(int radios)
        {
            this.height = radios;
            this.width = radios;
        }

        public override int CalculateSurface()
        {
            return (int)(height * Math.PI) / 2;
        }
    }
}
