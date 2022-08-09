using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input number:");
            int Num = Convert.ToInt32(Console.ReadLine());

            for (int Idx = 1; Idx <= Num; Idx++)
            {
                if (Idx % 2 == 0)
                {
                    Console.Write(Idx == 2 ? "{0}" : ",{0}", Idx);
                }
            }

            Console.ReadKey();
        }
    }
}
