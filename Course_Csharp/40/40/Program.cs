using System;

namespace _40
{
    class Program  //Task_40
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a character string");
            string example = Console.ReadLine();


            char[] arrExample = example.ToCharArray();
            for (int i = 0; i < arrExample.Length; i++)
            {
                int value = Convert.ToInt32(arrExample[i]);
                for (int code = 65; code <= 90; code++)
                {
                    if (value == code)
                    {
                        value = code + 32;
                    }
                }

                string stringValue = char.ConvertFromUtf32(value);
                Console.Write(stringValue);
            }
        }
    }
}
