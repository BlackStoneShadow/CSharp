using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A(3,6,8); B(2,1,-7), -> 15.84
//A(7,-5, 0); B(1,-1,9) -> 11.53
namespace Task21
{
    struct Point
    {
        public Point(int x, int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public int x { get; set; }
        public int y { get; set; }
        public int z { get; set; }
    }
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
        static Point ReadPoint(string Caption)
        {
            Console.WriteLine(Caption);

            int x = ReadNumber("x");
            int y = ReadNumber("y");
            int z = ReadNumber("z");

            return new Point(x, y, z);
        }
        static double Distance(Point A, Point B)
        {
            return Math.Sqrt(Math.Pow(B.x - A.x, 2) + Math.Pow(B.y - A.y, 2) + Math.Pow(B.z - A.z, 2));
        }
        static void Main(string[] args)
        {
            Point A = ReadPoint("Input point A");
            Point B = ReadPoint("Input point B");

            Console.WriteLine("Distance from A to B:{0:f2}", Distance(A, B));

            Console.ReadKey();
        }
    }
}
