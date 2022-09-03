using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Задайте двумерный массив.Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//В итоге получается вот такой массив:
//7 4 2 1
//9 5 3 2
//8 4 4 2
namespace Task54
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
        static int[,] SortArray(int[,] Array)
        {
            for (int I = 0; I < Array.GetLength(0); I++)
            {
                for (int J = 0; J < Array.GetLength(1); J++)
                {
                    for (int K = J; K < Array.GetLength(1); K++)
                    {
                        if (Array[I, J] < Array[I, K])
                        {
                            int Max = Array[I, K];

                            Array[I, K] = Array[I, J];

                            Array[I, J] = Max;
                        }
                    }
                }
            }

            return Array;
        }
        static void Main(string[] args)
        {
            int[,] Array = ArrayCreate(4, 4, new Random());

            Console.WriteLine("Input Array"); ArrayPrint(Array);
            Console.WriteLine("Output Array"); ArrayPrint(SortArray(Array));

            Console.ReadKey();
        }
    }
}
