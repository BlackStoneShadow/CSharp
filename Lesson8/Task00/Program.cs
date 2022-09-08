using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Напишите программу, которая будет принимать на вход //число и возвращать сумму его цифр
namespace Task00
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
            int Number = ReadNumber("Input number");

            int Sum = 0;
            while(Number > 0)
            {
                Sum += Number % 10; Number /= 10;
            }

            Console.WriteLine($"Sum={Sum}");

            Console.ReadKey();
        }
    }
}
