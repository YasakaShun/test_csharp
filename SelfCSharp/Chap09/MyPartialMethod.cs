using System;

namespace SelfCSharp.Chap09
{
    partial class MyPartialMethod
    {
        static partial void Log();

        static void Main(string[] args)
        {
            Log();
            Console.WriteLine("確認OK！");
        }
    }
}
