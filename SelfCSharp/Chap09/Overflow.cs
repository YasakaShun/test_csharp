using System;

namespace SelfCSharp.Chap09
{
    class Overflow
    {
        static void Main(string[] args)
        {
            var i = int.MaxValue;
            Console.WriteLine(++i);

            //checkedブロックで書き換え
            //try
            //{
            //    checked
            //    {
            //        var i = int.MaxValue;
            //        Console.WriteLine(++i);
            //    }
            //}
            //catch (OverflowException ex)
            //{
            //    Console.WriteLine("オーバーフロー発生！");
            //}

            //checked演算子で書き換え
            //var i = int.MaxValue;
            ////var i = 1;
            //Console.WriteLine(checked(++i));

        }
    }
}
