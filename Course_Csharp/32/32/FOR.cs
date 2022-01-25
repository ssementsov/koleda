using System;

namespace Task_32
{
    class FOR  //Task_32
    {
        static void Main(string[] args)
        {
            Console.Write("Введите первое число: ");
            int firstnumber = int.Parse(Console.ReadLine());
            Console.Write("Введите второе число: ");
            int secondnumber = int.Parse(Console.ReadLine());
            Console.Write("Введите шаг: ");
            float delta = float.Parse(Console.ReadLine());
            if (firstnumber > secondnumber)
            {
                for (float index = firstnumber; index >= secondnumber; index -= delta)
                {
                    Console.WriteLine(string.Format("{0:f1}", index));
                }
            }
            else
            {
                for (float i = firstnumber; i <= secondnumber; i += delta)
                {
                    Console.WriteLine(string.Format("{0:f1}", i));
                }
            }
        }
    }
}
