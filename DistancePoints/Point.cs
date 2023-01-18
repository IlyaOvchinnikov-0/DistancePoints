using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistancePoints
{
    class Point
    {
        double x;
        double y;

        public static Point CreatePoint(double x, double y)
        {
            var point = new Point();
            point.x = x;
            point.y = y;

            return point;
        }

        public double Distance(Point somePoint)
        {
            double x2 = this.x + somePoint.x;
            double y2 = this.y + somePoint.y;

            return Math.Sqrt(x2 * x2 + y2 * y2);
        }
    }
}
