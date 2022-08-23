using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Задайте одномерный массив, заполненный случайными числами.Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0
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
                Result[I] = random.Next(-100, 100);
            }

            return Result;
        }
        static int Sum(int[] Array)
        {
            int Result = 0;

            for (int I = 0; I < Array.Length; I++)
            {
                Result += I % 2 != 0 ? Array[I] : 0;
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
            Console.Write($"]->{Sum(Array)}");
        }
        static void Main(string[] args)
        {
            int N = ReadNumber("Input the length of the array");

            Print(Create(N, new Random()));

            Console.ReadKey();
        }
    }
}
