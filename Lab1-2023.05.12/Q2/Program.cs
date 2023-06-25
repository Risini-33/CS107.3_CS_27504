using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the radius of the circle : ");
            int r = int.Parse(Console.ReadLine());

            double area = Math.PI * Math.Pow(r,2);

            Console.WriteLine("\nArea of the circle is : " + area);

            Console.ReadLine();
        }
    }
}
