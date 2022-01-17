using System;

namespace Task_30
{
    class Array_1   
    {
        static void Main(string[] args)
        {
            string[] month = { "Январь", "Февраль", "Март", "Апрель", "Май", "Июнь", "Июль", "Август", "Сентябрь", "Октябрь", "Ноябрь", "Декабрь" };
            int index = 0;
            int index2 = 0;
            string[] month2 = new string[month.Length];
            while (index < month.Length)
            {
                Console.WriteLine(month[index]);
                index++;
            }
            while (index2 < month.Length)
            {
                Console.WriteLine($"Введите название {++index2} месяца");
                month2[--index2] = (Console.ReadLine());
                if (month2[index2] == month[index2])
                {
                    index2++;
                }
                else if (index2 == 4 & month2[4] != month[4])  
                {
                    break;
                }
            }
        }
    }
}
