using System;

namespace SelfCSharp.Chap04
{
    class Goto
    {
        static void Main(string[] args)
        {
            goto THERE;
            Console.WriteLine("ここはスキップされます。");

            THERE:
            Console.WriteLine("コードが終了しました。");

        }
    }
}
