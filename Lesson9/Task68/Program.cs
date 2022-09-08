using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task68
{
    //Напишите программу вычисления функции Аккермана с помощью рекурсии.Даны два неотрицательных числа m и n.
    //m = 3, n = 2->A(m, n) = 29
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

        static int FuncAkkermanCalc(int M, int N)
        {
            if (M == 0)
            {
                return N + 1;
            }
            else if (M > 0 && N == 0)
            {
                return FuncAkkermanCalc(M - 1, 1);
            }
            else
            {
                return FuncAkkermanCalc(M - 1, FuncAkkermanCalc(M, N - 1));
            }
        }
        static void Main(string[] args)
        {
            int M = ReadNumber("Input M");
            int N = ReadNumber("Input N");

            Console.WriteLine($"Result={FuncAkkermanCalc(M, N)}");

            Console.ReadKey();
        }
    }
}
