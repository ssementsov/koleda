using System;

namespace _08
{
    class Program_08
    {
        static void Main(string[] args)
        {
            int x = 10, y = 12, z = 3;
            x += y - x++ * z; Console.WriteLine(x); // -8
            z = --x - y * 5; Console.WriteLine(z);  // -69
            y /= x + 5 % z; Console.WriteLine(y);   // -3
            z = x++ + y * 5; Console.WriteLine(z);  // -24
            x = y - x++ * z; Console.WriteLine(x);  // -195
            Console.ReadKey();
        }
    }
}
