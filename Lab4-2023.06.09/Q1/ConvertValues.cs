using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
    internal class ConvertValues
    {
        public void kilometerTOmeter()
        {
            Console.Write("Enter value in KM : ");
            int km = int.Parse(Console.ReadLine());

            int m = km * 1000;

            Console.WriteLine($"\nIn meters (M) : {m}");
        }
    }
}
