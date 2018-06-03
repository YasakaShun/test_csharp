using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dokushu
{
    class Practice7_3
    {
        public static void Exec()
        {
            Console.WriteLine(GetBmi(60.0, 1.7));
        }

        public static double GetBmi(double aWeight, double aHeight)
        {
            return aWeight / (aHeight * aHeight);
        }
    }
}
