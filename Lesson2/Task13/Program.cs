using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task13
{
    class Program
    {
        static int ReadNumber()
        {
            while (true)
            {
                Console.Write("Input number:");

                if (Int32.TryParse(Console.ReadLine(), out int Result))
                {
                    return Result;
                }
                else
                {
                    Console.WriteLine("Error input!");
                }
            }
        }

        static void PrintThreeChar(int Number)
        {
            if (100 <= Math.Abs(Number))
            {
                string ArrayNumbers = Math.Abs(Number).ToString();

                Console.WriteLine("Third char:{0}", ArrayNumbers[2]);
            }
            else
            {
                Console.WriteLine("There is no third digit!");
            }
        }

        static void Main(string[] args)
        {
            PrintThreeChar(ReadNumber());

            Console.ReadKey();
        }
    }
}
