using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q7
{
    internal class Program
    {
        static void Main(string[] args)
        {   

            Console.Write("Enter the size of arrays: ");
            int size = int.Parse(Console.ReadLine());

            Console.Write("\n");

            int[] arr1 = new int[size];
            int[] arr2 = new int[size];

            for (int i = 0; i < size; i++)
            {
                Console.Write($"Enter the element {i + 1} for array 1: ");
                arr1[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("\n");

            for (int j = 0; j < size; j++)
            {
                Console.Write($"Enter the element {j + 1} for array 2: ");
                arr2[j] = int.Parse(Console.ReadLine());
            }

            /*Console.Write("\n");
            Console.Write("Enter the Scalar value: ");
            int scalar = int.Parse(Console.ReadLine());

            Console.Write("Enter the Vector value: ");
            int vector = int.Parse(Console.ReadLine());

            Console.Write("\n");
            Console.Write("Scalar Sum of array 1; ");

            for (int i = 0; i < size; i++)
            {
                arr1[i] = arr1[i] + scalar;
                Console.Write($"{arr1[i]},");
            }

            Console.Write("\n");
            Console.Write("Scalar Sum of array 2; ");

            for (int j = 0; j < size; j++)
            {
                arr2[j] = arr2[j] + scalar;
                Console.Write($"{arr2[j]},");
            }*/

            

            scalarVector objsc = new scalarVector();
            
            objsc.scalarSum(arr1, arr2);
            objsc.vectorSum(arr1, arr2);
            objsc.vectorProduct(arr1, arr2);
            objsc.scalarProduct(arr1, arr2);

            Console.ReadLine();
        }
    }
}
