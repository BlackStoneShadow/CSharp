using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1* x + b1, y = k2* x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9-> (-0, 5; -0,5)
namespace Task43
{
    class Program
    {
        struct Point
        {
            float X { get; set; }
            float Y { get; set; }

            public Point(float X, float Y)
            {
                this.X = X;
                this.Y = Y;
            }
            public override string ToString()
            {
                return string.Format("X={0},Y={1}", X, Y);
            }
        }
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

        static Point LineCross(int b1, int b2, int k1, int k2)
        {
            float y = (float)(k1 * b2 - k2 * b1) / (k1 - k2);
            float x = (float)(y - b1) / k1;

            return new Point(x, y);
        }

        static void Main(string[] args)
        {
            int b1 = ReadNumber("Input b1");
            int k1 = ReadNumber("Input k1");

            int b2 = ReadNumber("Input b2");
            int k2 = ReadNumber("Input k2");

            Point Result = LineCross(b1:b1, k1:k1, b2:b2, k2:k2);

            Console.WriteLine("Result:{0:f2}", Result);

            Console.ReadKey();
        }
    }
}
