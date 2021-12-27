using System;

namespace _10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(5 + double.NaN);
            Console.WriteLine(5 - double.NaN);
            Console.WriteLine(5 * double.NaN);
            Console.WriteLine(5 / double.NaN);
            Console.WriteLine(5 % double.NaN);
            Console.WriteLine(0f / 0);
            Console.WriteLine(float.PositiveInfinity / float.PositiveInfinity);
            Console.WriteLine(0 * float.PositiveInfinity);
            Console.WriteLine(float.PositiveInfinity + float.NegativeInfinity);
            Console.WriteLine(Math.Sqrt(-4));
            Console.WriteLine(Math.Log(-4));
        }
    }
}
