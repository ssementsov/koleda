using System;

namespace Task_35
{
    class Program  //Task_35
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размер первой матрицы");
            Console.Write("Количество строк    = ");
            int firstRows = int.Parse(Console.ReadLine());
            Console.Write("Количество столбцов = ");
            int firstColumns = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите размер второй матрицы");
            Console.Write("Количество строк    = ");
            int secondRows = int.Parse(Console.ReadLine());
            Console.Write("Количество столбцов = ");
            int secondColumns = int.Parse(Console.ReadLine());
            int[,] first = new int[firstRows, firstColumns];
            int[,] second = new int[secondRows, secondColumns];
            int[,] multiplied = new int[firstRows, secondColumns];
            if (firstColumns != secondRows)
            {
                Console.WriteLine("Неверный размер второй матрицы");
            }
            else
            {
                Console.WriteLine("Введите значения первой матрицы:");
                for (int first_row = 0; first_row < firstRows; first_row++)
                {
                    for (int first_col = 0; first_col < firstColumns; first_col++)
                    {
                        first[first_row, first_col] = int.Parse(Console.ReadLine());
                    }
                }
                Console.WriteLine("Введите значения второй матрицы:");
                for (int second_row = 0; second_row < secondRows; second_row++)
                {
                    for (int second_col = 0; second_col < secondColumns; second_col++)
                    {
                        second[second_row, second_col] = int.Parse(Console.ReadLine());
                    }
                }
                // Произведение матриц
                for (int first_row = 0; first_row < firstRows; first_row++)
                {
                    for (int second_col = 0; second_col < secondColumns; second_col++)
                        {
                        for (int first_col = 0; first_col < firstColumns; first_col++)
                        {
                            multiplied[first_row, second_col] += first[first_row, first_col] * second[first_col, second_col];
                        }
                    }
                }
            }
            Console.WriteLine("--------------------");
            for (int first_row = 0; first_row < firstRows; first_row++)
            {
                for (int first_col = 0; first_col < firstColumns; first_col++)
                {
                    Console.Write($"{first[first_row, first_col], +3} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("--------------------");
            for (int second_row = 0; second_row < secondRows; second_row++)
            {
                for (int second_col = 0; second_col < secondColumns; second_col++)
                {
                    Console.Write($"{second[second_row, second_col], +3} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("--------------------");
            for (int first_row = 0; first_row < firstRows; first_row++)
            {
                for (int second_col = 0; second_col < secondColumns; second_col++)
                {
                    Console.Write($"{multiplied[first_row, second_col], +3} ");
                }
                Console.WriteLine();
            }
        }
    }
}
