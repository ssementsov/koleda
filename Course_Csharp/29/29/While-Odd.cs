using System;

namespace Task_29
{
    class Odd  //Task_29
    {
        static void Main(string[] args)
        {          
            Console.Write("Введите первое целое число: ");
            int firstnumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите второе целое число: ");
            int secondnumber = Convert.ToInt32(Console.ReadLine());
            if (firstnumber > secondnumber)
            {
                int temp = secondnumber;
                secondnumber = firstnumber;
                firstnumber = temp;
            }
            firstnumber++;
            while (firstnumber < secondnumber)
            {                
                if (firstnumber % 2 == 1 || firstnumber % 2 == -1)
                {
                    Console.WriteLine(firstnumber);
                    firstnumber += 2;
                }
                else
                {
                    firstnumber++;
                }
            }
        }
    }
}
