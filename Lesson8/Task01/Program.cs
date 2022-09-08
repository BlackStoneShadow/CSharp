using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Напишите программу, которая на вход принимает два числа A и B, //и возводит число А в целую степень B с помощью рекурсии.
namespace Task01
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
        static int Power(int A, int B)
        {
            if (B > 1)
            {
                return A * Power(A, B - 1);
            }
            else
            {
                return A;
            }
        }
        static void Main(string[] args)
        {
            int A = ReadNumber("Input A");
            int B = ReadNumber("Input B");

            Console.WriteLine($"Power={Power(A, B)}");

            Console.ReadKey();
        }
    }
}