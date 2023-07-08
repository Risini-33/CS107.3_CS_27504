using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q7
{
    internal class scalarVector
    {
        public void scalarSum(int[] arr1, int[] arr2)
        {
            Console.Write("\n");
            int scalarSum1 = 0;
            foreach (int i in arr1)
            {
                scalarSum1 += i;
            }
            Console.Write("Scalar Sum of array 1: " + scalarSum1);

            Console.Write("\n");
            int scalarSum2 = 0;
            foreach (int i in arr2)
            {
                scalarSum2 += i;
            }
            Console.Write("Scalar Sum of array 2: " + scalarSum2);

        }
        public void vectorSum(int[] arr1, int[] arr2)
        {
            
            int[] vectorSum = new int[arr1.Length];
            for (int i = 0; i<arr1.Length; i++)
            {
                vectorSum[i]= arr1[i]+arr2[i];
            }
            
            Console.Write("\n\nVector Sum : ");
            for (int j = 0; j<arr1.Length; j++)
            {
                Console.Write($"{vectorSum[j]},");
            }
            
        }
        public void vectorProduct(int[] arr1, int[] arr2)
        {
            int[] vectorProduct = new int[arr1.Length];
            for (int i = 0;i<arr1.Length; i++)
            {
                vectorProduct[i]= arr1[i] * arr2[i];
            }

            Console.Write("\n\nVector Product : ");
            for (int j = 0; j < arr1.Length; j++)
            {
                Console.Write($"{vectorProduct[j]},");
            }
        }
        public void scalarProduct(int[] arr1, int[] arr2)
        {
            int scalarProduct = 0;
            int[] sparray = new int[arr1.Length];
            for (int i =0; i< arr1.Length; i++)
            {
                sparray[i] = arr1[i] *arr2[i];
                scalarProduct = scalarProduct + sparray[i];
            }

            Console.Write($"\n\nScalar Product : {scalarProduct}");

        }
    }
}
