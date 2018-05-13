using System;

namespace SelfCSharp.Chap07
{
    class ScopeBlock3
    {
        static void Main(string[] args)
        {
            {
                {
                    var data = "ローカルスコープ";
                    Console.WriteLine(data);
                }

                {
                    var data = "ローカルスコープ2";
                    Console.WriteLine(data);
                }
            }
        }
    }
}
