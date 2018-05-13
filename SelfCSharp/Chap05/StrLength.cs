using System;

namespace SelfCSharp.Chap05
{
    class StrLength
    {
        static void Main(string[] args)
        {
            var str1 = "WINGSプロジェクト";
            Console.WriteLine(str1.Length);

            var str2 = "𠮟る";
            Console.WriteLine(str2.Length);
        }
    }
}
