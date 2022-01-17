using System;

namespace Task_33
{
    class BubbleSorting  // Task_33
    {
        static void Main(string[] args)
        {
            int[] ascend = { 146, 110, 66, 139, 7, 86, 71, 97, 96, 160, 138, 67, 145, 133, 183, 185, 23, 124, 177, 150, 104, 48, 77, 147, 63, 113, 132, 100, 107, 106 };
            int[] descend = new int[ascend.Length];            
            int temp, i, j, flag;
            for (i=0; i< ascend.Length; i++)
            {
                descend[i] = ascend[i];
            }
            for (i = 1; i < ascend.Length; i++)
            {                
                flag = 0;
                for (j = 0; j < ascend.Length - i; j++)
                {
                    if (ascend[j] > ascend[j + 1])  // сортировка по возрастанию
                    {
                        temp = ascend[j];
                        ascend[j] = ascend[j + 1];
                        ascend[j + 1] = temp;
                        flag = 1;
                    }                  
                    if (descend[j] < descend[j + 1])  // сортировка по убыванию
                    {
                        temp = descend[j];
                        descend[j] = descend[j + 1];
                        descend[j + 1] = temp;
                        flag = 1;
                    }                    
                }
                if (flag == 0)
                {
                    break;
                }
            }
            Console.WriteLine("Сортировка по возрастанию:");
            for (i=0; i< ascend.Length; i++)
            {
                Console.Write($"{ascend[i]} ");
            }
            Console.WriteLine("\n Сортировка по убыванию:");
            for (i = 0; i < descend.Length; i++)
            {
                Console.Write($"{descend[i]} ");
            }
            Console.ReadKey();
        }
    }
}
