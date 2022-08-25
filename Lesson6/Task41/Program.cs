using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Пользователь вводит с клавиатуры M чисел.Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3
namespace Task41
{
    class Program
    {
        static int[] Read(string Caption)
        {
            Console.Write($"{Caption}:");

            string[] Array = Console.ReadLine().Split(',');

            int[] Result = new int[Array.Length];

            for (int I = 0; I < Result.Length; I++)
            {
                if (int.TryParse(Array[I], out int Number))
                {
                    Result[I] = Number;
                }
            }

            return Result;
        }
        static int Count(int[] Array)
        {
            int Result = 0;

            for (int I = 0; I < Array.Length; I++)
            {
                Result += Array[I] > 0 ? 1 : 0;
            }

            return Result;
        }
        static void Print(int[] Array)
        {
            Console.Write("[{0}]->{1}", string.Join(",", Array), Count(Array));
        }
        static void Main(string[] args)
        {
            Print(Read("Input array"));

            Console.ReadKey();
        }
    }
}
