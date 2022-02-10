using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _106
{
    class BaseClass
    {
        public int field1;
        public int field2;

        public BaseClass(int field1, int field2)
        {
            this.field1 = field1;
            this.field2 = field2;
            Console.WriteLine($"{field1}, {field2}");
        }
    }
}
