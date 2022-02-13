using System;

namespace _108
{
    class Program  //Task_108
    {
        static void Main(string[] args)
        {
            var phone1 = new Phone("123-45-67", "Nokia", 100);
            var phone2 = new Phone("993-45-67", "Sumsung", 110);
            var phone3 = new Phone("444-45-67", "Xiaomi", 120);

            phone1.PrintConsole();
            phone2.PrintConsole();
            phone3.PrintConsole();
            Console.WriteLine();

            phone1.ReceiveCall("Zvonkevich");
            Console.WriteLine(phone1.GetNumber("123-45-67"));
            Console.WriteLine();

            phone2.ReceiveCall("Piotr");
            Console.WriteLine(phone2.GetNumber("993-45-67"));
            Console.WriteLine();

            phone3.ReceiveCall("Tania");
            Console.WriteLine(phone3.GetNumber("444-45-67"));
            Console.WriteLine();

            phone1.ReceiveCall("Zvonkevich", "123-45-67");
            phone2.ReceiveCall("Piotr", "993-45-67");
            phone3.ReceiveCall("Tania", "444-45-67");

            Console.ReadKey();
        }
    }
}
