using System;

namespace _52
{
    class Program //Task_52
    {
        static void Main(string[] args)
        {
            Console.Write("Number in the sequence:");
            uint number = Convert.ToUInt32(Console.ReadLine());
            uint f = Fibonacci(number);
            Console.WriteLine($"Fibonacci {number} = {f}");
            Console.ReadKey();
        }
        static uint Fibonacci(uint n)
        {
            if (n <= 1)
            {
                return 0;
            }
            else if (n == 2)
            {
                return 1;
            }
            else
            {
                uint n1 = 0, n2 = 1, sum = 0;
                for (int i = 2; i <= n; i++)
                {
                    n1 = n2;
                    n2 = sum;
                    sum = n1 + n2;
                }
                return sum;
            }
        }
    }
}
