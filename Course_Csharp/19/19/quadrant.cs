using System;

namespace Task_19
{
    class quadrant
    {
        static void Main(string[] args)
        {
            int x = 0, y = 0;
            string quadrant = "I";
            Console.Write("Введите координату Х:");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите координату Y:");
            y = Convert.ToInt32(Console.ReadLine());
            int i = x * y;
            switch (i > 0)
            {
                case true:
                    quadrant = (x > 0) ? "I" : "III";
                    Console.WriteLine($"{quadrant}");
                    break;
                case false:
                    quadrant = (x > 0) ? "IV" : "II";
                    Console.WriteLine($"{quadrant}");
                    break;
            }
            Console.ReadKey();
        }
    }
}
