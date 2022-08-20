using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Напишите цикл, который принимает на вход два числа(A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16
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
        static void Main(string[] args)
        {            
            int A = ReadNumber("Input number A");
            int B = ReadNumber("Input number B");

            int Result = A;

            for (int I = 1; I < B; I++)
            {
                Result = Result * A;
            }

            Console.WriteLine($"Result:{Result}");
            Console.ReadKey();
        }
    }
}
