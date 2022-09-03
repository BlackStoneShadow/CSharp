using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Напишите программу, которая заполнит спирально массив 4 на 4.
//Например, на выходе получается вот такой массив:
//01 02 03 04
//12 13 14 05
//11 16 15 06
//10 09 08 07
namespace Task62
{
    class Program
    {
        static int[,] ArrayFill(int[,] Array, int I, int J, int Number)
        {
            Array[I, J] = Number;

            if (J + 1 < Array.GetLength(1) && Array[I, J + 1] == 0 && (I > 0 && Array[I - 1, J] != 0 || I == 0))
            {
                return ArrayFill(Array, I, J + 1, Number + 1); // Move right
            }
            else if (I + 1 < Array.GetLength(0) && Array[I + 1, J] == 0)
            {
                return ArrayFill(Array, I + 1, J, Number + 1); // Move down
            }
            else if (J > 0 && Array[I, J - 1] == 0)
            {
                return ArrayFill(Array, I, J - 1, Number + 1); //Move left
            }
            else if (I > 0 && Array[I - 1, J] == 0)
            {
                return ArrayFill(Array, I - 1, J, Number + 1); //Move up
            }

            return Array;
        }
        static void ArrayPrint(int[,] Array)
        {
            for (int I = 0; I < Array.GetLength(0); I++)
            {
                for (int J = 0; J < Array.GetLength(1); J++)
                {
                    Console.Write("{0:d2}\t", Array[I, J]);
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            ArrayPrint(ArrayFill(new int[4, 4], 0, 0, 1));

            Console.ReadKey();
        }
    }
}
