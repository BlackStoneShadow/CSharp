using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да
namespace Task19
{
    class Program
    {
        static int ReadFiveDigitNumber()
        {
            while (true)
            {
                Console.Write("Input five-digit number:");

                if (Int32.TryParse(Console.ReadLine(), out int Result) && (9999 < Math.Abs(Result) && Math.Abs(Result) < 100000))
                {
                    return Result;
                }
                else
                {
                    Console.WriteLine("Error input!");
                }
            }
        }

        static bool IsPalindromeMethodSum(int Number)
        {            
            int SumDir = 0;
            int SumRev = 0;

            string StringNumber = Convert.ToString(Number);

            for (int I = 0; I < StringNumber.Length; I++)
            {
                int J = StringNumber.Length - I - 1;

                SumDir += StringNumber[I] * (I + 1);
                SumRev += StringNumber[J] * (StringNumber.Length - J);
            }
            
            return SumDir == SumRev ? true : false;
        }

        static bool IsPalindromeMethodArray(int Number)
        {
            string NumberString = Convert.ToString(Number);

            for(int I = 0; I < NumberString.Length; I++)
            {
                if (NumberString[I] != NumberString[NumberString.Length - (I + 1)])
                {
                    return false;
                }
            }

            return true;
        }

        static bool IsPalindromeMethodString(int Number)
        {
            string StrDir = Convert.ToString(Number);
            string StrRev = new string(StrDir.Reverse().ToArray());

            return StrDir == StrRev ? true : false;
        }

        static void Print(bool Result, string Method)
        {
            if (Result)
            {
                Console.WriteLine($"Number is palindrome(Method:{Method})");
            }
            else
            {
                Console.WriteLine($"Number is not palindrome(Method:{Method})");
            }
        }

        static void Main(string[] args)
        {
            int Number = ReadFiveDigitNumber();

            Print(Method:"sum compare", Result: IsPalindromeMethodSum(Number));
            Print(Method:"array compare", Result: IsPalindromeMethodArray(Number));
            Print(Method:"string compare", Result:IsPalindromeMethodString(Number));

            Console.ReadKey();
        }
    }
}
