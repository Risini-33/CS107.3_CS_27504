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
            Console.Write("Enter number 1 : ");
            double num1 = double.Parse(Console.ReadLine());

            Console.Write("Enter number 2 : ");
            double num2 = double.Parse(Console.ReadLine());

            double sum = num1 + num2;
            double sub = num1 - num2;
            double mul = num1 * num2;
            double div = num1 / num2;

            Console.Write($"\nSummation : {sum} \nSubtraction : {sub} \nMultiplication : {mul} \nDivision : {div}");

            Console.ReadLine();
        }
    }
}
