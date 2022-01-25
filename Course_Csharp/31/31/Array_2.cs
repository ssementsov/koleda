using System;

namespace Task_31
{
    class Array_2 //Task_31
    {
        static void Main(string[] args)
        {
            int i = 0;
            Console.Write("Введите размер массива = ");
            int arraySize = int.Parse(Console.ReadLine());
            int[] numbers = new int[arraySize];
            while (i < numbers.Length)
            {
                Console.Write($" Введите {i} элемент = ");
                numbers[i] = int.Parse(Console.ReadLine());
                i++;
            }            
            int temp;
            for (i = 0; i < numbers.Length - 1; i++)  //сортировка по убыванию
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] < numbers[j])
                    {
                        temp = numbers[i];
                        numbers[i] = numbers[j];
                        numbers[j] = temp;
                    }
                }
            }
            Console.WriteLine("Массив отсортирован по убыванию");
            for (i = 0; i < numbers.Length; i++)
            {
                Console.Write($"{ numbers[i]}, ");
            }            
            Console.Write($"\n Введите дополнительный элемент = ");
            int newElement= int.Parse(Console.ReadLine());
            int[] tempNumbers = new int[numbers.Length + 1];
            for (i=0; i<numbers.Length; i++)  //копирование массива
            {
                tempNumbers[i] = numbers[i];
            }
            tempNumbers[tempNumbers.Length - 1] = newElement;
            numbers = tempNumbers;
            i = 0;
            while(i<numbers.Length)
            {
                Console.Write($"{numbers[i]}, ");
                i++;
            }
        }
    }
}
