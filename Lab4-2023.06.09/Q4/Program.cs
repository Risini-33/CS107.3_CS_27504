using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the radius of the circle : ");
            int r = int.Parse(Console.ReadLine());

            double area = Math.PI * Math.Pow(r, 2);
            double circum = 2 * Math.PI * r;

            Console.WriteLine("\nArea of the circle is : " + area);
            Console.WriteLine("\nCircumference of the circle is : " + circum);

            Console.ReadLine();
        }
    }
}
