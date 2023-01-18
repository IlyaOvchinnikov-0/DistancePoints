using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistancePoints
{
    class Program
    {
        static void Main(string[] args)
        {
            var p1 = Point.CreatePoint(1, 5);
            var p2 = Point.CreatePoint(1, 2);

            Console.WriteLine(p1.Distance(p2));
            Console.ReadKey();
        }
    }
}
