using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Задайте массив вещественных чисел.Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76
namespace Task25
{
    class Program
    {
        static float[] ReadArray(string Caption)
        {
            Console.Write($"{Caption}:");

            string[] Array = Console.ReadLine().Split(Convert.ToChar(32));

            float[] Result = new float[Array.Length];

            for (int I = 0; I < Result.Length; I++)
            {
                if (float.TryParse(Array[I], out float Number))
                {
                    Result[I] = Number;
                }
            }

            return Result;
        }
        static float DiffMinMax(float[] Array)
        {
            float Min = Array[0];
            float Max = Array[0];

            for (int I = 1; I < Array.Length; I++)
            {
                Min = Array[I] < Min ? Array[I] : Min;
                Max = Array[I] > Max ? Array[I] : Max;
            }

            return Max - Min;
        }
        static void Print(float[] Array)
        {
            Console.Write("[");
            for (int I = 0; I < Array.Length; I++)
            {
                Console.Write("{0} ", Array[I]);
            }
            Console.Write($"]->{DiffMinMax(Array)}");
        }
        static void Main(string[] args)
        {
            Print(ReadArray("Input array"));

            Console.ReadKey();
        }
    }
}
