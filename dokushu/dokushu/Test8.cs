using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dokushu
{
    class Test8
    {
        public static void Exec_2()
        {
            Console.WriteLine("hoge".ToTitleCase());
            Console.WriteLine("foo".ToTitleCase());
            Console.WriteLine("bar".ToTitleCase());
        }
    }

    static class StringExtension
    {
        public static string ToTitleCase(this string aStr)
        {
            var head = aStr.Substring(0, 1).ToUpper();
            var body = aStr.Substring(1).ToLower();
            return head + body;
        }
    }
}
