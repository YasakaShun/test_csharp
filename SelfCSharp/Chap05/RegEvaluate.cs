using System;
using System.Text.RegularExpressions;

namespace SelfCSharp.Chap05
{
    class RegEvaluate
    {
        static void Main(string[] args)
        {
            var str = "メールアドレスはwings@example.comです。";
            var rgx = new Regex(@"[a-z0-9._-]+@[a-z0-9._-]+\.[a-z]{2,4}");
            Console.WriteLine(rgx.Replace(str, m => m.Value.ToUpper()));
        }
    }
}
