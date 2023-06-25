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
            Console.Write("Enter the number of positive integrs : ");
            int Loop = Convert.ToInt32(Console.ReadLine());

            int sum = 0;
            for (int i = 0; i < Loop; i++)
            {
                Console.Write($"\nEnter the value {i+1} : ");
                int num = Convert.ToInt32(Console.ReadLine());

                if (num % 2 == 0)
                {
                    Console.Write("Invalid input\n");
                }
                else
                {
                    sum += num;
                }
            }

            Console.WriteLine($"\nSum is : {sum}");


            Console.ReadKey();
        }
    }
}
