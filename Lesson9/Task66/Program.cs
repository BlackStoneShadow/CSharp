using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Задайте значения M и N.Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30
namespace Task66
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
        static int Sum(int M, int N)
        {
            int Result = M;

            if (N > M)
            {
                Result += Sum(M + 1, N);
            }

            return Result;
        }
        static void Main(string[] args)
        {
            int M = ReadNumber("Input M");
            int N = ReadNumber("Input N");

            Console.WriteLine($"Sum={Sum(M, N)}");

            Console.ReadKey();
        }
    }
}
