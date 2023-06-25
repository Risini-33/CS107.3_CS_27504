using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q5
{
    internal class FindValues
    {
        public double findArea(int r)
        {
            double area = Math.PI * Math.Pow(r, 2);

            return area;
        }
        public double findCircumference(int r)
        {
            double circum = 2 * Math.PI * r;

            return circum;
        }
    }
}
