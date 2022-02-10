using System;

namespace _39
{
    class Overloads // Task_39
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Введите задание: ");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            string s = "-";

            int result1 = PrintResult(a, b, c);
            int result2 = PrintResult(a, b, c, s);
            int result3 = PrintResult(a, b);

            Console.WriteLine($"\n{result1}");
            Console.WriteLine(result2);
            Console.WriteLine(result3);
            Console.WriteLine($"\"{a}\" + \"{b}\" + \"{c}\"");
        }

        static int PrintResult(int a, int b, int c)
        {
            int sum = a + b + c;
            return sum;
        }
        static int PrintResult(int a, int b, int c, string s)
        {
            int sub = a - b - c;
            return sub;
        }
        static int PrintResult(int a, int b)
        {
            int squ = (int)Math.Pow(a, b);
            return squ;
        }
    }
}
