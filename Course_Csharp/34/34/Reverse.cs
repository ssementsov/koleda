using System;

namespace Task_34
{
    class Reverse  // Task_34
    {
        static void Main(string[] args)
        {
            int[] number = { 146, 110, 66, 139, 7, 86, 71, 97, 96, 160, 138, 67, 145, 133, 183, 185, 23, 124, 177, 150, 104, 48, 77, 147, 63, 113, 132, 100, 107, 106};
            int i, temp;
            int length = number.Length / 2;
            for (i=0; i<length; i++)
            {
                temp = number[i];
                number[i] = number[number.Length - 1 - i];
                number[number.Length - 1 - i] = temp;
            }
            for (i = 0; i < number.Length; i++)
            {
                Console.Write($"{number[i]} ");
            }
        }
    }
}
