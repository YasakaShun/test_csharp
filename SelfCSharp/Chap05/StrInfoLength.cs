using System;
using System.Globalization;

namespace SelfCSharp.Chap05
{
    class StrInfoLength
    {
        static void Main(string[] args)
        {
            var str = "𠮟る";
            StringInfo strInfo = new StringInfo(str);
            Console.WriteLine(strInfo.LengthInTextElements);
        }
    }
}
