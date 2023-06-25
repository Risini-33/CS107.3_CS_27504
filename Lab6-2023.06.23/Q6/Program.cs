using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of the array: ");
            int size = int.Parse(Console.ReadLine());

            arrayInput objarray = new arrayInput();

            objarray.inputarray(size);

            Console.ReadLine();
        }
    }
}
