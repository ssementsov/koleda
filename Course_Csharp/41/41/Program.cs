using System;

namespace _41
{
    class Program  //  Task_41
    {
        static void Main(string[] args)
        {
            string[] stringArr = { "aabdccdbcacd", "aad" };
            string result = MinSubstring(stringArr);
            Console.Write(result);
            Console.ReadLine();
        }
        static int n = 0;
        static string MinSubstring(string[] stringArr)
        {
            char[] basicStr = stringArr[0].ToCharArray();
            char[] checkedStr = new char[stringArr[0].Length];
            char[] checkedStr2 = new char[stringArr[0].Length];
            char[] checkedOut = new char[stringArr[0].Length];
            int i, j;
            int minIndex = 0;
            int minSum = 0;
            for (n = 0; n < stringArr[0].Length; n++)
            {
                int counter = 0;
                char[] controlStrTemp = stringArr[1].ToCharArray();
                for (i = n; i < stringArr[0].Length; i++)
                {
                    for (j = 0; j < stringArr[1].Length; j++)
                    {
                        if (basicStr[i] == controlStrTemp[j])
                        {
                            controlStrTemp[j] = ' ';
                            checkedStr[i] = basicStr[i];
                            counter++;
                            break;
                        }
                    }
                    if (counter == stringArr[1].Length)
                    { break; }
                }
                int sumDistances = CalculationOfTheAmountOfDistances(checkedStr);
                if (n == 0)
                {
                    minSum = sumDistances;
                    minIndex = 0;
                }
                if (minSum > sumDistances & sumDistances != 0 & counter == stringArr[1].Length)
                {
                    minSum = sumDistances;
                    minIndex = n;
                }
            }
            int counter2 = 0;
            char[] controlStrTemp2 = stringArr[1].ToCharArray();
            for (i = minIndex; i < stringArr[0].Length; i++)
            {
                for (j = 0; j < stringArr[1].Length; j++)
                {
                    if (basicStr[i] == controlStrTemp2[j])
                    {
                        controlStrTemp2[j] = ' ';
                        checkedStr2[i] = basicStr[i];
                        counter2++;
                        break;
                    }
                    else
                    {
                        checkedStr2[i] = basicStr[i];
                    }
                }
                if (counter2 == stringArr[1].Length)
                { break; }
            }
            for (i = minIndex, j = 0; i < checkedOut.Length; i++)
            {
                if (checkedStr2[i] != '0')
                {
                    checkedOut[j] = checkedStr2[i];
                    j++;
                }
            }
            string result = new string(checkedOut);
            return result;
        }
        static int CalculationOfTheAmountOfDistances(char[] checkedStr)
        {
            int sumDistances = 0;
            int[] s = new int[checkedStr.Length];
            for (int i = n; i < checkedStr.Length; i++)
            {
                if (checkedStr[i] != 0)
                {
                    s[i] = i;
                }
            }
            for (int i = n; i < checkedStr.Length; i++)
            {
                for (int j = n; j < checkedStr.Length; j++)
                {
                    if (checkedStr[i] != 0 & checkedStr[j] != 0)
                    {
                        sumDistances += Math.Abs(s[i] - s[j]);
                    }
                }
            }
            return sumDistances / 2;
        }
    }
}
