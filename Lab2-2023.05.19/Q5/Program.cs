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
            for (int i =0; i < 10; i++)
            {
                Console.Write($"\nEnter a number {i+1}: ");
                int num = int.Parse(Console.ReadLine());

                if (num % 2 == 0)
                    Console.WriteLine("Even");
                else
                    Console.WriteLine("Odd");

            }

            Console.ReadLine();


        }
    }
}
