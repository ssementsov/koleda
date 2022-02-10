using System;

namespace _106
{
    class Program //Task_106
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Select option (1 or 2)");
            string value = Console.ReadLine();

            if (value == "1")
            {
                var additional1 = new Additional1(15, 25, 35);
            }
            else
            {
                var additional2 = new Additional2(450, 505, 105, 110);
            }
        }
    }
}
