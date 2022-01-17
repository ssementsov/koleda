using System;

namespace Task_24
{
    class Mixing
    {
        static void Main(string[] args)
        {
            int i;
            Console.Write("Введите первую строку: ");
            char[] firstArray = Console.ReadLine().ToCharArray();
            Console.Write("Введите вторую строку: ");
            char[] secondArray = Console.ReadLine().ToCharArray();
            for (i = 0; i < firstArray.Length; i++)
            {
                Console.Write($"{firstArray[i]}{secondArray[i]}");         
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
