using System;

namespace Task_22
{
    class Calculator //№22
    {
        static void Main(string[] args)
        {
            double a = 0, b = 0, result=0;
            string sign;
            Console.Write("Введите первое число = ");
            a = Convert.ToInt64(Console.ReadLine());
            Console.Write("Введите второе число = ");
            b = Convert.ToInt64(Console.ReadLine());
            Console.Write("Введите знак арифметической операции: ");
            sign = Console.ReadLine();
            switch (sign)
            {
                case "+":
                    result = a + b;
                    break;
                case "-":
                    result = a - b;
                    break;
                case "*":
                    result = a * b;
                    break;
                case "/":
                    result = a / b;
                    break;               
            }
            Console.WriteLine($"Результат = {result}"); ;
            Console.ReadKey();
        }
    }
}
