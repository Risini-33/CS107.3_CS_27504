using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q5
{
    internal class @class
    {
        public void min(int[] array)
        {
            int min = array[0];

            for (int i = 0; i<array.Length; i++)
            {
                if (array[i] < min)
                    min = array[i];
            }

            Console.Write("\nMinimum value is : " + min);
        }
        public void max(int[] array)
        {
            int max = array[0];

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                    max = array[i];
            }

            Console.Write("\nMaximum value is : " + max);
        }
        public void avg(int[] array)
        {
            double avg = 0;
            double sum =0;

            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }

            avg = sum / array.Length;
            Console.Write("\nAverage value is : " + avg);
        }
        public void reverse(int[] array)
        {
            int[] reverse = new int[array.Length];
            int j = 9;
            int temp = array[j];

            for (int i = 0; i < array.Length; i++)
            {
                temp = array[j];
                array[j] = reverse[i];
                reverse[i] = temp;
                j--;
            }

            Console.Write("\nReversed array: ");

            for(int l=0; l <reverse.Length; l++)
            {
                Console.Write($"{reverse[l]},");
            }
        }
    }
}
