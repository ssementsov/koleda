using System;

namespace Task_21
{
    class rectangle //№21
    {
        static void Main(string[] args)
        {
            double a = 0, b = 0;
            string comand;
            double perimeter;
            double square;
            Console.Write("Введите сторону А : ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите сторону В : ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write($"Введите команду Площадь или Периметр :");
            comand = Console.ReadLine();
            if (a == b)
            {
                Console.WriteLine("Данный прямоугольник – квадрат");
            }
            if (comand == "Площадь")
            {
                square = a * b;
                Console.WriteLine($"Площадь = {square}");
            }
            else if (comand == "Периметр")
            {
                perimeter = (a + b) * 2;
                Console.WriteLine($"Периметр = {perimeter}");
            }
            else
            {
                Console.WriteLine("Неверная команда!");
            }
            Console.ReadKey();
        }
    }
}
