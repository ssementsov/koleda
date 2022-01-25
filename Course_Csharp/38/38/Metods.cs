using System;

namespace _38
{
    class Metods
    {
        static int Method_1(int var1, int var2, int var3)
        {
            int sum = var1 + var2 + var3;
            return sum;
        }
        static int Method_2(ref int var1, ref int var2, ref int var3)
        {
            var1++;
            var2++;
            var3++;
            int sum = var1 + var2 + var3;
            return sum;
        }
        static int Method_3(int var1, int var2, int var3, bool check)
        {

            if (check == true)
            {
                int sum = Method_1(var1, var2, var3);

                return sum;
            }
            else
            {
                int sum = Method_2(ref var1, ref var2, ref var3);
                return sum;
            }
        }

        static void Main(string[] args)
        {
            int var1 = 1;
            int var2 = 2;
            int var3 = 3;
            bool check = true;

            int result1 = Method_1(var1, var2, var3);
            int result2 = Method_2(ref var1, ref var2, ref var3);
            int result3 = Method_3(var1, var2, var3, check);

            Console.WriteLine(result1);
            Console.WriteLine(result2);
            Console.WriteLine(result3);
        }

    }
}
