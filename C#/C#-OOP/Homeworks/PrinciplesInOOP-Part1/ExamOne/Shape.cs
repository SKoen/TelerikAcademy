using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateSurface
{
    abstract class Shape
    {
        protected int width;
        protected int height;

        public abstract int CalculateSurface();
    }
}
