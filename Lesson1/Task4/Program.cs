using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input number1:");
            int Num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input number2:");
            int Num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input number3:");
            int Num3 = Convert.ToInt32(Console.ReadLine());

            int NumMax = Num1;

            if (Num2 > NumMax)
            {
                NumMax = Num2;
            }
            if (Num3 > NumMax)
            {
                NumMax = Num3;
            }

            Console.WriteLine("Max number {0}", NumMax);

            Console.ReadKey();
        }
    }
}
