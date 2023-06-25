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
            int[] array = new int[10];

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"Enter value for element {i} : ");
                array[i] = int.Parse(Console.ReadLine());
            } 

            @class objcls = new @class();

            objcls.min(array);
            objcls.max(array);
            objcls.avg(array);
            objcls.reverse(array);

            Console.ReadLine();

        }              
    }
}
