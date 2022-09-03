using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Задайте  две матрицы.Напишите программу, которая будет находить произведение двух матриц.
//Например, даны 2 матрицы:
//2 4 | 3 4
//3 2 | 3 3
//Результирующая матрица будет:
//18 20
//15 18
namespace Task58
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
                    Result[I, J] = Rnd.Next(10);
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
        static int[,] ArrayMultiplication(int[,] Array1, int[,] Array2)
        {
            int[,] Result = new int[Array1.GetLength(0), Array1.GetLength(1)];

            for (int I = 0; I < Array1.GetLength(0); I++)
            {
                for (int J = 0; J < Array1.GetLength(0); J++)
                {
                    for (int K = 0; K < Array1.GetLength(0); K++)
                    {
                        Result[I, J] += Array1[I, K] * Array2[K, J];
                    }
                }
            }

            return Result;
        }
        static void Main(string[] args)
        {
            int[,] Array1 = ArrayCreate(2, 2, new Random());
            int[,] Array2 = ArrayCreate(2, 2, new Random());

            Console.WriteLine("Array1"); ArrayPrint(Array1);
            Console.WriteLine("Array2"); ArrayPrint(Array2);

            Console.WriteLine("Result"); ArrayPrint(ArrayMultiplication(Array1, Array2));

            Console.ReadKey();
        }
    }
}
