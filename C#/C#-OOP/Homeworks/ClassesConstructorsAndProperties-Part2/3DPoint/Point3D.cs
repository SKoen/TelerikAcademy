using System;

namespace ThreeDPoint
{
    struct Point3D
    {
        public int x { get; set; }
        public int y { get; set; }
        public int z { get; set; }

        public override string ToString()
        {
            return x.ToString() + "," + y.ToString() + "," + z.ToString();
        }

        //private static readonly int ZeroPoint(int x, int y, int z)
        //{
        //    return 0;
        //}

        public int Zero { get{return 0;} }
    }
}
