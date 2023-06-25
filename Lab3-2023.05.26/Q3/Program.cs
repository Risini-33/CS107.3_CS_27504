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
            int i, sum = 0;
            Console.Write("Enter the number of integers you going to add : ");
            int num = int.Parse(Console.ReadLine());

            Console.Write("\n");
            for (i = 0; i < num; i++)
            {
                Console.Write($"Enter the number {i + 1} : ");
                int value = int.Parse(Console.ReadLine());
                sum = sum + value;
            }

            Console.WriteLine($"\nThe sum of given numbers is : {sum}");

            Console.ReadKey();
        }
    }
}
