using System;
//Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
//m = 3, n = 4.
//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8 7,8 -7,1 9
namespace Task47
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
        static float[,] CreateArray(int M, int N, Random Rnd)
        {
            float[,] Result = new float[M, N];
            
            for (int I = 0; I < Result.GetLength(0); I++)
            {
                for (int J = 0; J < Result.GetLength(1); J++)
                {
                    Result[I, J] = Rnd.Next(-100, 100) / 10f;
                }
            }

            return Result;
        }
        static void PrintArray(float[,] Array)
        {
            for (int I = 0; I < Array.GetLength(0); I++)
            {
                for (int J = 0; J < Array.GetLength(1); J++)
                {
                    Console.Write("{0:f1}\t", Array[I, J]);
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            int m = ReadNumber("Input dimension m");
            int n = ReadNumber("Input dimension n");

            PrintArray(CreateArray(m, n, new Random()));

            Console.WriteLine($"m={m},n={n}");

            Console.ReadKey();
        }
    }
}
