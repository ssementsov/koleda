using System;

namespace Fruits
{
    class Program
    {
       static void Main(string[] args)
        {
            //int pear = 8;
            //double apple = 5.5;
            //double fruits = pear + apple;
            //Console.WriteLine("Имеется  " + fruits+ "  фруктов");
            //{
            //    int consoleColor;

            //    for (consoleColor = 0; consoleColor <= 15; consoleColor++)
            //    {
            //        Console.ForegroundColor = (ConsoleColor)consoleColor;

            //        Console.WriteLine("Foreground color set to " + (ConsoleColor)consoleColor);
            //    }
            //    Console.ReadKey();
            //}
            {
                string template = "Background color set to ";
                Array colors = Enum.GetValues(typeof(ConsoleColor));

                foreach (ConsoleColor color in colors)
                {
                    Console.ForegroundColor = color;
                    Console.WriteLine(template + color.ToString());
                }

                Console.ReadKey();
            }
        }
    }
}
