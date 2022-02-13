using System;

namespace _44
{
    class Program  // Task_44
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string");
            string baseString = Console.ReadLine();
            char[] arrBase = baseString.ToCharArray();
            char t;
            for (int j = 0; j < 3; j++)
            {
                for (int i = 0; i < baseString.Length - 1; i++)
                {
                    t = arrBase[i];
                    arrBase[i] = arrBase[i + 1];
                    arrBase[i + 1] = t;
                }
            }
            for (int i = 0; i < baseString.Length / 2; i++)
            {
                t = arrBase[i];
                arrBase[i] = arrBase[baseString.Length - 1 - i];
                arrBase[baseString.Length - 1 - i] = t;
            }
            string target = new string(arrBase);
            Console.Write("\n" + target);
        }
    }
}
