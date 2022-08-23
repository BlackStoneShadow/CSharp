using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Доп задание которое проходили на уроки самостоятельно
//Задача 35: Задайте одномерный массив из 123 случайных чисел.Найдите количество элементов массива, значения которых лежат в отрезке[10, 99].
//Пример для массива из 5, а не 123 элементов.В своём решении сделайте для 123
//[5, 18, 123, 6, 2] -> 1
//[1, 2, 3, 6, 2] -> 0
//[10, 11, 12, 13, 14] -> 5
namespace Task35
{
    class Program
    {
        static int[] Create(Random random, int N)
        {
            int[] Result = new int[N];
            
            for (int I = 0; I < Result.Length; I++)
            {                
                Result[I] = random.Next(100);
            }

            return Result;
        }

        static int Count(int[] Array)
        {
            int Result = 0;

            for (int I = 0; I < Array.Length; I++)
            {
                Result += 10 <= Array[I] && Array[I] <= 99 ? 1 : 0;
            }

            return Result;
        }

        static void Print(int[] Array)
        {
            Console.Write("[");
            for (int I = 0; I < Array.Length; I++)
            {
                Console.Write(I < Array.Length - 1 ? "{0}," : "{0}", Array[I]);
            }
            Console.Write($"]->{Count(Array)}");
        }
        static void Main(string[] args)
        {
            const byte ArraySize = 123;

            Print(Create(new Random(), ArraySize));

            Console.ReadKey();
        }
    }
}
