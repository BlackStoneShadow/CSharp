using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Задайте прямоугольный двумерный массив.
//Напишите программу, которая будет находить строку с наименьшей суммой элементов.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//5 2 6 7
//Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
namespace Task56
{
    class Program
    {
        static int[,] ArrayCreate(int M, int N, Random Rnd)
        {
            int[,] Result = new int[M, N];

            for (int I = 0; I < Result.GetLength(0); I++)
            {
                for (int J = 0; J < Result.GetLength(1); J++)
                {
                    Result[I, J] = Rnd.Next(100);
                }
            }

            return Result;
        }
        static void ArrayPrint(int[,] Array)
        {
            for (int I = 0; I < Array.GetLength(0); I++)
            {
                for (int J = 0; J < Array.GetLength(1); J++)
                {
                    Console.Write("{0}\t", Array[I, J]);
                }
                Console.WriteLine();
            }
        }
        static int ArrayMinSumRow(int[,] Array)
        {
            int Result = 0;
            int SumMin = 0;

            for (int I = 0; I < Array.GetLength(0); I++)
            {
                int Sum = 0;

                for (int J = 0; J < Array.GetLength(1); J++)
                {
                    Sum += Array[I, J];
                }

                if (SumMin > Sum || SumMin == 0)
                {
                    SumMin = Sum;
                    Result = I;
                }                
            }

            return Result;
        }

        static void Main(string[] args)
        {
            int[,] Array = ArrayCreate(4, 4, new Random());

            Console.WriteLine("Input Array"); ArrayPrint(Array);
            Console.WriteLine("Min row {0}", ArrayMinSumRow(Array));

            Console.ReadKey();
        }
    }
}
