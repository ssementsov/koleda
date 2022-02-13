using System;

namespace _47
{
    class Program //Task_47
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string");
            string baseString = Console.ReadLine();
            string result = SortAndMove(baseString);
            Console.WriteLine(result);
        }
        static string SortAndMove(string baseString)
        {
            char[] arrBase = baseString.ToCharArray();
            char temp;
            int i, j = 0;
            for (i = 1; i < baseString.Length; i++)
            {
                for (j = 0; j < baseString.Length - i; j++)
                    if (arrBase[j] > arrBase[j + 1])
                    {
                        temp = arrBase[j];
                        arrBase[j] = arrBase[j + 1];
                        arrBase[j + 1] = temp;
                    }
            }
            for (j = 0; j < 2; j++)
            {
                for (i = baseString.Length - 1; i > 0; i--)
                {
                    temp = arrBase[i];
                    arrBase[i] = arrBase[i - 1];
                    arrBase[i - 1] = temp;
                }
            }
            return new string(arrBase);
        }
    }
}
