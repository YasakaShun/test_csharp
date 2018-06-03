using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dokushu
{
    class Practice7_2
    {
        public static void Exec()
        {
            var circle = new Circle(2.0);

            Console.WriteLine(circle.GetArea());
        }
    }

    class Circle
    {
        private double radius { get; set; }

        public Circle(double aRadius = 1.0)
        {
            radius = aRadius;
        }

        public double GetArea()
        {
            return radius * radius * Math.PI;
        }
    }
}
