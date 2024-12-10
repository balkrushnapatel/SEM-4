using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    internal class AreaCalculate
    {
        public double AreaOfSquare(double l)
        {
            return l * l;
        }

        public double AreaOfRectangle(double l, double b)
        {
            return l * b;
        }

        public double AreaOfCircle(double r)
        {
            return 3.14 * r * r;
        }
    }
}
