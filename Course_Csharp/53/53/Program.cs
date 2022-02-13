using System;

namespace _53
{
    class Program  //Task_53
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter numbers");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int nod = NOD(a, b);
            Console.WriteLine($"NOD {a}, {b} = {nod}");
            Console.ReadKey();
        }
        static int NOD(int value1, int value2)
        {
            if (value1 % value2 == 0)
            {
                return value2;
            }
            return NOD(value2, value1 % value2);
        }
    }
}
