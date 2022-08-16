using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Напишите программу, которая принимает на вход число(N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125
namespace Task23
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
            int N = ReadNumber("Input N");

            Console.SetCursorPosition("Input N".Length + N.ToString().Length + 1, 0); Console.Write("->");

            for (int I = 1; I <= N; I++)
            {
                Console.Write(I < N ? "{0}," : "{0}", Math.Pow(I, 3));
            }

            Console.ReadKey();
        }
    }
}
