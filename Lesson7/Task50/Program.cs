using System;
//напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.
//например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//17 -> такого числа в массиве нет
namespace Task50
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
        static bool ArrayFind(int[,] Array, int Number)
        {
            bool Result = false;

            for (int I = 0; I < Array.GetLength(0); I++)
            {
                for (int J = 0; J < Array.GetLength(1); J++)
                {
                    if (Array[I, J] == Number)
                    {
                        Console.WriteLine($"Array[{I},{J}]={Number}");

                        Result = true;
                    }
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
        static void Main(string[] args)
        {
            int[,] Array = ArrayCreate(4, 4, new Random());

            ArrayPrint(Array);

            int Number = ReadNumber("Input numbr");

            if (!ArrayFind(Array, Number))
            {
                Console.WriteLine($"{Number} not found!");
            }

            Console.ReadKey();
        }
    }
}
