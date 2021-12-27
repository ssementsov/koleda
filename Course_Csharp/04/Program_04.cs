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



            //Console.WriteLine(5 + double.NaN);
            //Console.WriteLine(0f / 0);
            
            //float zero = 0;
            //float positive = 1 / zero;
            //Console.WriteLine(positive);    // Outputs "Infinity"
            //float negative = -1 / zero;
            //Console.WriteLine(negative);    // Outputs "-Infinity"
            //Console.WriteLine("PositiveInfinity plus 10.0 equals {0}.", (Double.PositiveInfinity + 10.0));
        
        }
    }
}
