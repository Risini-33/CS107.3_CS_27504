using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number 1 : ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter number 2 : ");
            int num2 = int.Parse(Console.ReadLine());   

            int sum = num1 + num2;

            Console.WriteLine("\nSum : " + sum);

            Console.ReadLine();
        }
    }
}
