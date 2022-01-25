using System;

namespace _13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("ФИО:");
            string name = Console.ReadLine();
            Console.Write($"{name} имеет работу?: ");
            bool isEmployment = Console.ReadLine().Contains("да");
            Console.Write($"{name} является пенсионером?: ");
            bool isPensioner = Console.ReadLine().Contains("да");
            Console.Write($"{name} состоит на учете?: ");
            bool isUnemployed = Console.ReadLine().Contains("да");
            bool subsidyAllowed = !isEmployment & isPensioner || !isEmployment & !isPensioner & isUnemployed;
            Console.WriteLine($"Право на субсидию: {subsidyAllowed}");
            Console.ReadLine();
        }
    }
}
