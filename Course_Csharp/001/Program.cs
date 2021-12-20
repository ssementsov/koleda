using System;

namespace _001
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("Hello,");
            Console.ResetColor();
            Console.ReadKey();
        }
    }
}
