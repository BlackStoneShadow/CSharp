using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input number a:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input number b:");
            int b = Convert.ToInt32(Console.ReadLine());

            if (a > b)
            {
                Console.Write("the number a is greater than the number b");
            }
            else if (a < b)
            {
                Console.Write("the number b is greater than the number a");
            }
            else
            {
                Console.Write("the numbers are equal");
            }

            Console.ReadKey();
        }
    }
}
