using System;

namespace SelfCSharp.Chap07
{
    class ScopeBlock
    {
        static void Main(string[] args)
        {
            var data = "ローカルスコープ";
            {
                //var data = "ブロックスコープ";
                Console.WriteLine(data);
            }
            Console.WriteLine(data);
        }
    }
}
