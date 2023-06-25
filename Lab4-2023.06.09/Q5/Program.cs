using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the radius of the circle : ");
            int r = int.Parse(Console.ReadLine());

            
            FindValues circle = new FindValues();


            Console.WriteLine("\nArea of the circle is : " + circle.findArea(r));
            Console.WriteLine("\nCircumference of the circle is : " + circle.findCircumference(r));

            Console.ReadLine();
        }
    }
}
