using System;

namespace _46
{
    class Program  //Task_46
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string");
            string baseString = Console.ReadLine();
            string result = DeletDoubleSymbol(baseString);
            Console.WriteLine(result);
        }
        static string DeletDoubleSymbol(string baseString)
        {
            char[] arrBase = baseString.ToCharArray();
            char[] arrControl = baseString.ToCharArray();
            char temp;
            int i, j, k = 0;
            for (i = 0; i < baseString.Length; i++)
            {
                k = 0;
                for (j = 0; j < baseString.Length; j++)
                {
                    if (arrBase[i] == arrControl[j])
                    {
                        k++;
                        if (k > 1)
                        {
                            arrBase[j] = '\0';
                        }
                    }
                }
            }
            for (j = baseString.Length - 1; j > 0; j--)
            {
                for (i = baseString.Length - 1; i > 0; i--)
                {
                    if (arrBase[i] == '\0')
                    {
                        temp = arrBase[i];
                        arrBase[i] = arrBase[i - 1];
                        arrBase[i - 1] = temp;
                    }
                }
            }
            for (i = 0; i < baseString.Length / 2; i++)
            {
                temp = arrBase[i];
                arrBase[i] = arrBase[baseString.Length - 1 - i];
                arrBase[baseString.Length - 1 - i] = temp;
            }
            return new string(arrBase);
        }
    }
}
