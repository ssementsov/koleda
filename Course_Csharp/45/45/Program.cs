using System;

namespace _45
{
    class Program // Task_45
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string");
            string baseString = Console.ReadLine();
            //string baseString = "LLondooonn";
            string result = DoublGroup(baseString);
            Console.WriteLine(result);
        }
        static string DoublGroup(string baseString)
        {
            char[] arrBase = baseString.ToCharArray();
            char[] arrOut = new char[baseString.Length * 2];
            int group = 0; int k = 0; int i = 0;
            for (i = 0; i < baseString.Length - 1; i++)
            {
                int j = i; group = 1;
                while (arrBase[j] == arrBase[j + 1])
                {
                    j++;
                    group++;
                    i = j;
                    if (i == baseString.Length - 1)
                    { break; }
                }
                if (group > 1)
                {
                    for (int g = 0; g < group * 2; g++)
                    {
                        arrOut[k] = arrBase[i];
                        k++;
                    }
                }
            }
            string resultArr = new string(arrOut);
            return resultArr;
        }
    }
}
