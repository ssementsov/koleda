using System;

namespace _002
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine("World!");
            Console.ReadKey(); 
            Console.ResetColor();
        }
    }
}
