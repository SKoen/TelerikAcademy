using System;

namespace ThreeDPoint
{
    class Distance
    {
        static Point3D GetDistace(Point3D point, Point3D pointTwo)
        {
            Point3D newPoint = new Point3D();
            if (point.x == pointTwo.x && point.y == pointTwo.y && point.z == pointTwo.z)
            {
                newPoint.x = 0;
                newPoint.y = 0;
                newPoint.z = 0;
            }   
            else
            {
                if (point.x > pointTwo.x)
                {
                    newPoint.x = point.x - pointTwo.x;
                }
                else
                {
                    newPoint.x = pointTwo.x - point.x;
                }
                if (point.y > pointTwo.y)
                {
                    newPoint.y = point.y - pointTwo.y;
                }
                else
                {
                    newPoint.y = pointTwo.y - point.y;
                }
                if (point.x > pointTwo.x)
                {
                    newPoint.z = point.z - pointTwo.z;
                }
                else
                {
                    newPoint.z = pointTwo.x - point.z;
                }
            }
            return newPoint;
        }

    }
}
