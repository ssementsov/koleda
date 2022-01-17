using System;

namespace Task_20
{
    class Triangle
    {
        static void Main(string[] args)
        {
            double a = 0, b = 0, c = 0;
            Console.Write("Введите длину А:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите длину В:");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите длину С:");
            c = Convert.ToInt32(Console.ReadLine());
            double aPow = Math.Pow(a, 2);
            double bPow = Math.Pow(b, 2);
            double cPow = Math.Pow(c, 2);
            if ((a + b > c) & (b + c > a) & (a + c > b))
            {
                Console.WriteLine($"Треугольник со сторонами {a}, {b}, {c} существует");
                if (a == b & b == c & a == c)
                {
                    Console.WriteLine($"Треугольник со сторонами {a}, {b}, {c} равносторонний");
                }
                else if ((a == b) | (b == c) | (a == c))
                {
                    Console.WriteLine($"Треугольник со сторонами {a}, {b}, {c} равнобедренный");
                }
                else if ((aPow + bPow == cPow) | (aPow + cPow == bPow) | (bPow + cPow == aPow))
                {
                    Console.WriteLine($"Треугольник со сторонами {a}, {b}, {c} прямоугольный");
                }
            }
            else
            {
                Console.WriteLine($"Треугольник со сторонами {a}, {b}, {c} НЕ существует");
            }
            Console.ReadKey();
        }
    }
}
