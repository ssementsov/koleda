using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _106
{
    class Additional1 : BaseClass
    {
        public int field3;
        public Additional1(int field1, int field2, int field3)
            : base(field1, field2)
        {
            this.field3 = field3;
            Console.WriteLine($"{field1}, {field2}, {field3}");
        }
    }
}
