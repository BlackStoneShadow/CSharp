using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Напишите программу, которая задаёт массив из N элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]
namespace Task29
{
    class Program
    {
        static int[] Create(string Array)
        {
            string[] StringArray = Array.Split(',');

            int[] Result = new int[StringArray.Length];

            for (int I = 0; I < Result.Length; I++)
            {
                Result[I] = int.Parse(StringArray[I]);
            }

            return Result;
        }

        static void Print(int[] Array)
        {            
            Console.Write("->[");
            for (int I = 0; I < Array.Length; I++)
            {
                Console.Write(I < Array.Length - 1 ? "{0}," : "{0}", Array[I]);
            }
            Console.Write("]");
        }

        static void Main(string[] args)
        {
            Console.Write("Input array:");

            string Array = Console.ReadLine();

            Console.SetCursorPosition("Input array:".Length + Array.Length, 0);

            Print(Create(Array));

            Console.ReadKey();
        }
    }
}
