using System;

namespace _14
{
    class Program
    {
        static void Main(string[] args)
        {
            int timeSum;
            float tax = 20, costPerQuarter, rate = 2;
            Console.Write($"Минуты за январь : ");
            int timeJan = Convert.ToInt32(Console.ReadLine());
            Console.Write($"Минуты за февраль: ");
            int timeFeb = Convert.ToInt32(Console.ReadLine());
            Console.Write($"Минуты за март   : ");
            int timeMar = Convert.ToInt32(Console.ReadLine());
            timeSum = timeJan + timeFeb + timeMar;
            costPerQuarter = rate * timeSum;
            tax = (float)(costPerQuarter * tax / 100);
            Console.Write($"Всего разговоров : {timeSum} минут\n");
            Console.Write($"Общая стоимость  : {costPerQuarter} рублей\n");
            Console.Write($"Заплатить налог  : {tax} рублей");
            Console.ReadKey();
        }
    }
}
