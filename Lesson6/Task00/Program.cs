using System;
// ловля фрукта, управление стрелками
namespace Task00
{ 
    class Program
    {
        static void Main(string[] args)
        {
            int[,] number = 
            { 
                  {0,0,0,0,0,0,0},
                  {0,0,0,0,2,0,0},
                  {0,0,0,0,2,0,0},
                  {0,0,0,1,2,0,0},
                  {0,0,0,0,0,0,0},
                  {0,0,0,0,0,0,0}
            };
            //int row = int.Parse(Console.ReadLine());
            //int column = int.Parse(Console.ReadLine());
            //int[,] num = new int[row,column];
            int row = 3;
            int column = 3;
            int oldRow = 0;
            int oldColumn = 0;
            int rowFruit = 0;
            int colFruit = 0;
            int count = 0;
            Random rnd = new Random();
            while (true)
            {                
                if (rowFruit == 0 && colFruit == 0)
                {                    
                    do
                    {                        
                        rowFruit = rnd.Next(number.GetLength(0));
                        colFruit = rnd.Next(number.GetLength(1));
                    } while (number[rowFruit, colFruit] != 0);

                    number[rowFruit, colFruit] = 3;
                }

                for (int i = 0; i < number.GetLength(0); i++)
                {
                    for (int j = 0; j < number.GetLength(1); j++)
                    {
                        Console.Write(number[i, j] + " ");
                    }
                    Console.WriteLine();                    
                }
                Console.Write($"Count={count}");

                number[row, column] = 0;

                oldRow = row; oldColumn = column;

                ConsoleKeyInfo key = Console.ReadKey();

                if (key.Key == ConsoleKey.UpArrow)
                {
                    row--;
                }
                if (key.Key == ConsoleKey.DownArrow)
                {
                    row++;
                }
                if (key.Key == ConsoleKey.LeftArrow)
                {
                    column--;
                }
                if (key.Key == ConsoleKey.RightArrow)
                {
                    column++;
                }
                if (key.Key == ConsoleKey.Escape)
                {
                    break;
                }

                if (row > number.GetLength(0) - 1)
                {
                    row = number.GetLength(0) - 1;
                }
                if (row < 0)
                {
                    row = 0;
                }
                if (column > number.GetLength(1) - 1)
                {
                    column = number.GetLength(1) - 1;
                }
                if (column < 0)
                {
                    column = 0;
                }
                if (row == rowFruit && column == colFruit)
                {
                    rowFruit = 0; colFruit = 0; count++;
                }

                Console.Clear();

                if (number[row, column] == 2)
                {
                    row = oldRow; column = oldColumn; 
                }

                number[row, column] = 1;
            }
        }
    }
}




