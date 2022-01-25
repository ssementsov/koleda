using System;

namespace Task_18_2
{
    class Program  // Task_18
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            int number = int.Parse(Console.ReadLine());           
            if (number/10 < 0)
            {
                Console.WriteLine("Ошибка. Однозначное число.");
            }
            else
            {
                int i = 0; int d = number; int n1; int divider; int palindrom = number;
                do
                {
                    d /= 10;
                    i++;
                }
                while (d > 0);
                int[] arrNumber= new int[i];
                for (int j = 0; j < i; j++)
                {
                    divider = (int)Math.Pow(10,i - 1 - j);
                    n1 = number / divider;
                    arrNumber[j] = n1;
                    number -= n1 * divider;                    
                }
                int half = arrNumber.Length / 2;
                int p = 0;
                while (arrNumber[p] == arrNumber[arrNumber.Length - 1 - p] & p < half)
                {
                    p++;
                }
                if (p == half)
                {
                    Console.WriteLine($"Число {palindrom} — палиндром");
                }
                else
                {
                    Console.WriteLine($"Число {palindrom}  не является палиндромом");
                }
            }
            Console.ReadKey();
        }
    }
}
