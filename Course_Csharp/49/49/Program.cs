using System;

namespace _49
{
    class Factorial_5 //Task_49
    {
        static void Main(string[] args)
        {
            int number = 5;
            int f;
            f = Factorial(number);
            Console.WriteLine($"Factorial {number} = {f}");
            Console.ReadKey();
        }
        static int Factorial(int counter)
        {
            if (counter == 0)
            {
                return 1;
            }
            return counter * Factorial(counter - 1);
        }
    }
}
