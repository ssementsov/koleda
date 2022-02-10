using System;

namespace _50
{
    class Program //Task_50
    {
        static void Main(string[] args)
        {
            int number = 6;
            int factorial;
            factorial = Factorial(number);
            Console.WriteLine($"Factorial {number} = {factorial}");
            Console.ReadKey();
        }
        static int Factorial(int n)
        {
            int result = 1;
            for (; n > 0; --n)
            {
                result *= n;
            }
            return result;
        }
    }
}
