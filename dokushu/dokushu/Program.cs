using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dokushu
{
    class Program
    {
        static void Main(string[] args)
        {
            Kind kind = Kind.P5_1_2;

            switch (kind)
            {
                case Kind.P5_1_1: Practice5_1.Exec1(); break;
                case Kind.P5_1_2: Practice5_1.Exec2(); break;
                case Kind.P5_2_1: Practice5_2.Exec1(); break;
                case Kind.P5_2_2: Practice5_2.Exec2(); break;
                default: break;
            }

            return;
        }

        private enum Kind
        {
            P5_1_1,
            P5_1_2,
            P5_2_1,
            P5_2_2,
        }
    }
}
