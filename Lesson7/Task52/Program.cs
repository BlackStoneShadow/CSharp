using System;
//Задайте двумерный массив из целых чисел.Найдите среднее арифметическое элементов в каждом столбце.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
namespace Task52
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
            const int Indent = 5;

            for (int I = 0; I < Array.GetLength(1); I++)
            {
                float AvgSum = 0;

                for (int J = 0; J < Array.GetLength(0); J++)
                {
                    Console.SetCursorPosition(I * Indent, J);
                    Console.Write($"{Array[J, I]}");

                    AvgSum += Array[J, I];
                }

                AvgSum = AvgSum / Array.GetLength(0);

                Console.SetCursorPosition(I * Indent, Array.GetLength(0) + 0); Console.Write("----");
                Console.SetCursorPosition(I * Indent, Array.GetLength(0) + 1); Console.Write("{0:f1}", AvgSum);
            }
        }
        static void Main(string[] args)
        {
            ArrayPrint(ArrayCreate(3, 4, new Random()));

            Console.ReadKey();
        }
    }
}
