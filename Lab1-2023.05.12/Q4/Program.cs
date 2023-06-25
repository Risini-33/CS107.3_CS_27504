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
            Console.Write("Enter the salary : ");
            int salary = int.Parse(Console.ReadLine());

            Console.Write("Enter the tax rate (%) : ");
            int rate = int.Parse(Console.ReadLine());

            double newSalary = salary - ((salary/100) * rate);

            Console.Write("\nNew salary after tax : " + newSalary);

            Console.ReadLine();
        }
    }
}
