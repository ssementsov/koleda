using System;

namespace _09
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Single a = 2.7182818284590452f;
            System.Byte a1 = (System.Byte)2.7182818284590452;
            System.SByte a2 = (System.SByte)2.7182818284590452;
            System.Int16 a3 = (System.Int16)2.7182818284590452;
            System.UInt16 a4 = (System.UInt16)2.7182818284590452;
            System.Int32 a5 = (System.Int32)2.7182818284590452;
            System.UInt32 a6 = (System.UInt32)2.7182818284590452;
            System.Int64 a7 = (System.Int64)2.7182818284590452;
            System.UInt64 a8 = (System.UInt64)2.7182818284590452;
            System.Double a9 = (System.Double)2.7182818284590452;
            System.Decimal a10 = 2.7182818284590452m;// полностью безопасное преобразование
            Console.WriteLine(" float:{0} \n byte:{1} \n sbyte:{2} \n short:{3} " +
                "\n ushort:{4} \n int:{5} \n uint:{6} \n long:{7} \n ulong:{8} " +
                "\n double:{9} \n decimal:{10}", a, a1, a2, a3, a4, a5, a6, a7, a8, a9, a10);
        }
    }
}
