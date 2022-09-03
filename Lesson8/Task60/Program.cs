using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task60
{
//Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.Напишите программу, 
//которая будет построчно выводить массив, добавляя индексы каждого элемента.
//Массив размером 2 x 2 x 2
//66(0,0,0) 25(0,1,0)
//34(1,0,0) 41(1,1,0)
//27(0,0,1) 90(0,1,1)
//26(1,0,1) 55(1,1,1)
    class Program
    {        
        static int RndValue(int[,,] Array, Random Rnd)
        {
            int Result = Rnd.Next(99);

            for (int I = 0; I < Array.GetLength(0); I++)
            {
                for (int J = 0; J < Array.GetLength(1); J++)
                {
                    for (int K = 0; K < Array.GetLength(2); K++)
                    {
                        if (Array[I, J, K] == Result)
                        {
                            Result = RndValue(Array, Rnd);
                        }
                    }
                }
            }

            return Result;
        }
        static int[,,] ArrayCreate(int M, int N, int O)
        {
            int[,,] Result = new int[M, N, O];

            for (int I = 0; I < Result.GetLength(0); I++)
            {
                for (int J = 0; J < Result.GetLength(1); J++)
                {
                    for (int K = 0; K < Result.GetLength(2); K++)
                    {
                        Result[I, J, K] = RndValue(Result, new Random());
                    }
                }
            }

            return Result;
        }

        static void ArrayPrint(int[,,] Array)
        {
            for (int K = 0; K < Array.GetLength(2); K++)
            {
                for (int I = 0; I < Array.GetLength(0); I++)
                {
                    for (int J = 0; J < Array.GetLength(1); J++)
                    {
                        Console.Write("{0}({1},{2},{3})\t", Array[I, J, K], I, J, K);
                    }
                    Console.WriteLine();
                }
            }
        }
        static void Main(string[] args)
        {
            ArrayPrint(ArrayCreate(2, 2, 2));

            Console.ReadKey();
        }
    }
}
