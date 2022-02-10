using System;

namespace _42
{
    class Program  //Task_42
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a three-word sentence");
            string sentence = Console.ReadLine();
            char[] arrChar = sentence.ToCharArray();
            bool whitespace = false;
            int i, number1 = 0, number2 = 0;
            for (i = 0; i < arrChar.Length; i++)
            {
                if (arrChar[i] == '\u0020' & whitespace == false)
                {
                    number1 = i + 1;
                    whitespace = true;
                }
                else if (arrChar[i] == '\u0020' & whitespace == true)
                {
                    number2 = i - 1;
                }
            }
            for (i = number1; i <= number2; i++)
            {
                Console.Write(arrChar[i]);
            }
        }
    }
}
