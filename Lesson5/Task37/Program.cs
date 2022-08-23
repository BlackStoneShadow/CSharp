using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Найдите произведение пар чисел в одномерном массиве.Парой считаем первый и последний элемент, второй и предпоследний и т.д.Результат запишите в новом массиве.
//[1 2 3 4 5] -> 5 8 3
//[6 7 3 6] -> 36 21
namespace Task37
{
    class Program
    {
        static int[] ReadArray(string Caption)
        {
            Console.Write($"{Caption}:");

            string[] Array = Console.ReadLine().Split(Convert.ToChar(32));

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
        static int[] Product(int[] Array)
        {
            int Size = Convert.ToInt32(Math.Ceiling(Array.Length / 2.0));

            int[] Result = new int[Size];

            for (int I = 0; I < Result.Length; I++)
            {
                int IndexPair1 = I;
                int IndexPair2 = Array.Length - (I + 1);

                if (IndexPair1 == IndexPair2)
                {
                    Result[I] = Array[I];
                }
                else
                {
                    Result[I] = Array[IndexPair1] * Array[IndexPair2];
                }
            }

            return Result;
        }
        static void Print(int[] Array)
        {
            Console.Write("[");
            for (int I = 0; I < Array.Length; I++)
            {
                Console.Write(I == Array.Length - 1 ? "{0}" : "{0} ", Array[I]);
            }
            Console.Write("]");
        }
        static void Main(string[] args)
        {
            int[] Array = ReadArray("Input array");

            Print(Array);
            Console.Write("->");
            Print(Product(Array));

            Console.ReadKey();
        }
    }
}
