using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Задайте значения M и N.Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
//M = 1; N = 5. -> ""1, 2, 3, 4, 5""
//M = 4; N = 8. -> ""4, 5, 6, 7, 8""
namespace Task64
{
    class Program
    {
        static int ReadNumber(string Caption)
        {
            while (true)
            {
                Console.Write($"{Caption}:");

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
        static void PrintNumber(int M, int N)
        {
            if (N > M)
            {
                Console.Write($"{M},");

                PrintNumber(M + 1, N);
            }
            else
            {
                Console.Write($"{M}");
            }
        }
        static void Main(string[] args)
        {
            int M = ReadNumber("Input M");
            int N = ReadNumber("Input N");

            PrintNumber(M, N);

            Console.ReadKey();
        }
    }
}
