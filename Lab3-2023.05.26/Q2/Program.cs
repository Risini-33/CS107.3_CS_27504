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
            int num = 0;
            string vowels = "aeiouAEIOU";
            Console.Write("Enter your string : ");
            string str = Console.ReadLine();

            for (int i = 0; i < str.Length; i++)
            {
                if (vowels.Contains(str[i]))
                {
                    num++;
                }
            }

            Console.WriteLine($"\nNumber of vowels in the given string is : {num}");

            Console.ReadKey();
        }
    }
}
