using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task15
{
    class Program
    {
        private static Dictionary<string, bool> WeekDays = new Dictionary<string, bool>()
        {
            { "Monday", false },
            { "Tuesday", false },
            { "Wednes­day", false },
            { "Thursday", false },
            { "Friday", false },
            { "Saturday", true },
            { "Sunday", true }
        };
        static int ReadNumber()
        {
            while (true)
            {
                Console.Write("Input number of day week:");

                if (Int32.TryParse(Console.ReadLine(), out int Result) && (1 <= Result && Result <= 7))
                {
                    return Result;
                }
                else
                {
                    Console.WriteLine("Error input!");
                }
            }
        }

        static string DayName(int Day)
        {            
            return WeekDays.Keys.ToArray()[Day - 1];
        }       

        static void Main(string[] args)
        {
            string Day = DayName(ReadNumber());
            
            Console.WriteLine("Day {0} is {1}", Day, WeekDays[Day] == true ? "weekend" : "not weekend");

            Console.ReadKey();
        }
    }
}
