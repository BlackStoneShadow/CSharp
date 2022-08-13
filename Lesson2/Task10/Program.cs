using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    class Program
    {
        static int ReadThreeDigitNumber()
        {
            while (true)
            {
                Console.Write("Input three-digit number:");
                
                if (Int32.TryParse(Console.ReadLine(), out int Result) && (100 <= Math.Abs(Result) && Math.Abs(Result) <= 999))
                {
                    return Result;
                }
                else
                {
                    Console.WriteLine("Error input!");
                }
            }
        }

        static void PrintSecondChar(int Number)
        {
            if (100 <= Math.Abs(Number) && Math.Abs(Number) <= 999)
            {
                string ArrayNumbers = Math.Abs(Number).ToString();

                Console.WriteLine("Second char:{0}", ArrayNumbers[1]);
            }
            else
            {
                Console.WriteLine("The number must consist of three digits!");
            }
        }

        static void Main(string[] args)
        {            
            PrintSecondChar(ReadThreeDigitNumber());

            Console.ReadKey();
        }
    }
}
