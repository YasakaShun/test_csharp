using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dokushu
{
    class Practice7_4
    {
        public static void Exec()
        {
            Console.WriteLine(GetAverage(1.0));
            Console.WriteLine(GetAverage(1.0, 2.0));
            Console.WriteLine(GetAverage(1.0, 2.0, 3.0));
            Console.WriteLine(GetAverage(1.0, 2.0, 3.0, 4.0));
            Console.WriteLine(GetAverage(1.0, 2.0, 3.0, 4.0, 5.0));
            Console.WriteLine(GetAverage(1.0, 2.0, 3.0, 4.0, 5.0, 6.0));
        }

        public static double GetAverage(double aFirstValue, params double[] aValues)
        {
            var result = aFirstValue;

            foreach (var value in aValues)
            {
                result += value;
            }

            result /= (aValues.Length + 1);

            return result;
        }
    }
}
