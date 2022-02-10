using System;

namespace _104
{
    class Program  //Task_104
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the length of side 1 and side 2");
            double side1 = Convert.ToDouble(Console.ReadLine());
            double side2 = Convert.ToDouble(Console.ReadLine());

            var rectangle = new Rectangle(side1, side2);
            rectangle.AreaCalculator(side1, side2);
            double area = rectangle.Area;
            rectangle.PerimetrCalculator(side1, side2);
            double perimetr = rectangle.Perimetr;

            Console.WriteLine($"Area: {area}\nPerimetr: {perimetr}");
        }
    }
}
