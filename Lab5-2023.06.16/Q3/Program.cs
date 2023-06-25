using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_2023._06._16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CalculateValues objCal = new CalculateValues();

            bool flag = true;

            Console.WriteLine("Enter Number 1 : ");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Number 2 : ");
            int num2 = int.Parse(Console.ReadLine());

            while (flag)
            {
                Console.WriteLine("Enter 1 for Addition.\nEnter 2 for Subtraction. \nEnter 3 for Multiplcation. \nEnter 4 for Division.");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine(objCal.add(num1, num2));
                        break;
                    case 2:
                        Console.WriteLine(objCal.sub(num1, num2));
                        break;
                    case 3:
                        Console.WriteLine(objCal.mul(num1, num2));
                        break;
                    case 4:
                        Console.WriteLine(objCal.div(num1, num2));
                        break;
                    default:
                        Console.WriteLine("Invalid input.");
                        break;
                }
                Console.WriteLine("Enter 0 to exit or enter any number to continue.");
                int exit = int.Parse(Console.ReadLine());

                if (exit == 0)
                    flag = false;
            }
        }
    }
}
