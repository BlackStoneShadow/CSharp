using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Задайте массив заполненный случайными положительными трёхзначными числами.Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2
namespace Task25
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
        static int[] Create(int N, Random random)
        {
            int[] Result = new int[N];

            for (int I = 0; I < Result.Length; I++)
            {
                Result[I] = random.Next(100, 999);
            }

            return Result;
        }
        static int Count(int[] Array)
        {
            int Result = 0;

            for (int I = 0; I < Array.Length; I++)
            {
                Result += Array[I] % 2 == 0 ? 1 : 0;
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
            int N = ReadNumber("Input the length of the array");

            Print(Create(N, new Random()));

            Console.ReadKey();
        }
    }
}
