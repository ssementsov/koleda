using System;

namespace _05
{
    class Program_05
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;
            for (int i = 0; i <= 15; i++)
            {
                Console.BackgroundColor = (ConsoleColor)i;
                Console.WriteLine($"Background color set to {Console.BackgroundColor}                   ");
            }
            Console.ReadKey();
        }
    }
}
