using System;

namespace _51
{
    class Program  // Task_51
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Number in the sequence");
            int number = Convert.ToInt32(Console.ReadLine());
            int f;
            f = Fibonacci(number);
            Console.WriteLine($"Fibonacci {number} = {f}");

            Console.ReadKey();
        }
        static int Fibonacci(int n)
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
                return (Fibonacci(n - 1) + Fibonacci(n - 2));
            }
        }
    }
}
