using System;

namespace SelfCSharp.Chap08
{
    class MyParent
    {
        public MyParent()
        {
            Console.WriteLine("親です。");
        }
    }

    class MyChild : MyParent
    {
        public MyChild()
        {
            Console.WriteLine("子です。");
        }
    }

    class ConstNoArgs
    {
        static void Main(string[] args)
        {
            var c = new MyChild();
        }
    }
}
