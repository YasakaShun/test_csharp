using System;

namespace SelfCSharp.Chap07
{
    class ScopeBlock2
    {
        static void Main(string[] args)
        {
            {
                //var data = "ブロックスコープ";
                //Console.WriteLine(data);
            }
            var data = "ローカルスコープ";
            Console.WriteLine(data);
        }
    }
}
