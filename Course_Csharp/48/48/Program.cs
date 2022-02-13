using System;

namespace _48
{
    class Program //Task_48
    {
        static void Main(string[] args)
        {
            string baseString = "Напишите программу, в которой получите от пользователя" +
                 "некий объем текста. Сохраните этот текст в виде зубчатого массива, каждый" +
                " элемент которого – массив строк. Каждый массив строк должен представлять " +
                "собой набор строковых элементов, составляющих одно предложение общего текста," +
                " введенного пользователем, в котором слова разделены пробелами. Выведите на " +
                "экран все слова, сохраненные в структуре зубчатого массива и его элементов.";
            JaggedArray(baseString);
        }
        private static string JaggedArray(string text)
        {
            char[] arrChars = text.ToCharArray();
            int i, j = 0, s = 0;
            for (i = 0; i < text.Length; i++)
            {
                if (arrChars[i] == '\u002e')
                {
                    s++;
                }
            }
            char[][] sentence = new char[s][];
            int k = 0;
            for (i = 0, j = 1; i < text.Length; i++, j++)
            {
                if (arrChars[i] == '\u002e')
                {
                    sentence[k] = new char[j];
                    j = 0;
                    k++;
                    if (i == text.Length - 1)
                    {
                        break;
                    }
                    else if (arrChars[i + 1] == '\u0020')
                    {
                        i++;
                    }
                }
            }
            i = 0;
            for (k = 0; k < s; k++)
            {
                j = 0;
                for (; j < sentence[k].Length; i++, j++)
                {
                    if (i < text.Length)
                    {
                        sentence[k][j] = arrChars[i];
                        if (i + 1 == text.Length)
                        {
                            break;
                        }
                        if (arrChars[i] == '\u002e' & arrChars[i + 1] == '\u0020')
                        {
                            i++;
                        }
                    }
                }
            }
            string arrayOfArrays = "";
            for (k = 0; k < s; k++)
            {
                arrayOfArrays = new(sentence[k]);
                Console.WriteLine(arrayOfArrays);
            }
            return arrayOfArrays;
        }
    }
}
