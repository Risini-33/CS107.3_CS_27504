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
            Console.Write("Enter value in KM : ");
            int km = int.Parse(Console.ReadLine());

            ConvertValues km2m = new ConvertValues();

            km2m.kilometerTOmeter(km);

            Console.ReadLine();
        }
    }
}
