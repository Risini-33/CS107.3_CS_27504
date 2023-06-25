using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class arrayInput
    {
        public void inputarray(int size)
        {
            int[] array = new int[size];

            for (int i = 0; i < size; i = i + 2)
            {
                Console.WriteLine("Enter the value" + i);
                array[i] = int.Parse(Console.ReadLine());

                if (i + 1 < size)
                {
                    array[i + 1] = 0;
                }
            }

            for (int j = 0; j < array.Length; j++)
            {
                Console.Write($"{array[j]},");
            }
        }

    }
}
