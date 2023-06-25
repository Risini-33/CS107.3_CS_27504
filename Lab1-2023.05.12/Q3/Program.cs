using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Enter number 1 : ");
            int a  = int.Parse(Console.ReadLine());
            Console.Write("Enter number 2 : ");
            int b = int.Parse(Console.ReadLine());

            int sum = a + b;

            Console.Write("\nSum : "+sum);

            Console.ReadLine();
        }
    }
}
