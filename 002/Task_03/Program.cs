using System;

namespace Task_03
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, s;
            Console.WriteLine("Введите первое слагаемое и сумму");
            a = int.Parse(Console.ReadLine());
            s = int.Parse(Console.ReadLine());
            b = s - a;
            Console.WriteLine(s + "=" + a + "+" + b);
            Console.ReadKey();
        }
    }
}
