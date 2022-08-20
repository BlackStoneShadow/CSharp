using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12
namespace Task27
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
        static int MethodArithmetic(int Number)
        {
            int Result = 0;

            while (Number > 0)
            {
                Result += Number % 10;
                Number = Number / 10;
            }

            return Result;
        }
        static int MethodArray(int Number)
        {
            int Result = 0;
            string Array = Number.ToString();

            for (int I = 0; I < Array.Length; I++)
            {
                Result += Array[I] - '0';
            }

            return Result;
        }

        static void Main(string[] args)
        {
            int Number = ReadNumber("Input number");

            Console.WriteLine("Arithmetic method={0}", MethodArithmetic(Number));
            Console.WriteLine("Array method={0}", MethodArray(Number));
            Console.ReadKey();
        }
    }
}
