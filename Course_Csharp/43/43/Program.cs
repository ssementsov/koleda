using System;

namespace _43
{
    class Program  // Task_43
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the base string");
            string baseString = Console.ReadLine();
            string controlString = "12abc,.";
            bool outChar = false;
            char[] arrControl = controlString.ToCharArray();
            char[] arrBase = baseString.ToCharArray();
            int k = 0;
            char[] arrOut = new char[baseString.Length];

            for (int i = arrBase.Length - 1; i >= 0; i--)
            {
                for (int j = 0; j < arrControl.Length; j++)
                {
                    if (arrBase[i] != arrControl[j] & outChar == false)
                    {
                        outChar = true;
                    }
                    else if (arrBase[i] == arrControl[j])
                    {
                        outChar = false;
                        break;
                    }
                }
                if (outChar == true)
                {
                    k++;
                    arrOut[k - 1] = arrBase[i];
                    outChar = false;
                }
            }
            string target = new string(arrOut);
            Console.WriteLine("\n" + target);
            Console.ReadKey();
        }
    }
}
