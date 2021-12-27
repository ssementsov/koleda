using System;

namespace _04
{
    class Program_04
    {
        static void Main(string[] args)
        {
            for (int i=0; i<=15; i++)
            { 
                Console.ForegroundColor = (ConsoleColor)i;
                Console.WriteLine($"Foreground color set to {Console.ForegroundColor}");
            }
            Console.ReadKey();
        }
    }
}
