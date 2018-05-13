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
            Kind kind = Kind.P6_1_2;

            switch (kind)
            {
                case Kind.P5_1_1: Practice5_1.Exec1(); break;
                case Kind.P5_1_2: Practice5_1.Exec2(); break;
                case Kind.P5_2_1: Practice5_2.Exec1(); break;
                case Kind.P5_2_2: Practice5_2.Exec2(); break;
                case Kind.P5_3_1: Practice5_3.Exec1(); break;
                case Kind.P5_3_2: Practice5_3.Exec2(); break;
                case Kind.P6_1_2: Practice6_1.Exec2(); break;
                case Kind.T5_1: Test5.Exec1(); break;
                case Kind.T5_2: Test5.Exec2(); break;
                case Kind.T5_3: Test5.Exec3(args); break;
                case Kind.T5_4: Test5.Exec4(); break;
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
            P5_3_1,
            P5_3_2,
            T5_1,
            T5_2,
            T5_3,
            T5_4,
            P6_1_2,
        }
    }
}
