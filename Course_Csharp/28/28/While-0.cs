using System;

namespace Task_28
{
    class Program //№28
    {
        static void Main(string[] args)
        {
            int delta = 0;
            Console.Write("Введите целое число: ");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number > 0)
            {
                delta = -1;
            }
            else
            {
                delta = 1;
            }
            while (number != 0)
            {
                Console.WriteLine(number);
                number = number + delta;
            }
            Console.WriteLine(number);
            Console.ReadKey();
        }
    }
}
