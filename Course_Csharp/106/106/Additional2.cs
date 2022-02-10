using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _106
{
    class Additional2 : BaseClass
    {
        public int field4;
        public int field5;

        public Additional2(int field1, int field2, int field4, int field5)
            : base(field1, field2)
        {
            this.field4 = field4;
            this.field5 = field5;
            Console.WriteLine($"{field1}, {field2}, {field4}, {field5}");
        }
    }
}
