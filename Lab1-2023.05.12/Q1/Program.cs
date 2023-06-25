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
            Console.Write("Enter your name : ");
            string name = Console.ReadLine();

            Console.Write("Enter your batch : ");
            string batch = Console.ReadLine();

            Console.WriteLine($"\nYour name is {name} and your batch is {batch}.");

            Console.ReadLine();
        }
    }
}
