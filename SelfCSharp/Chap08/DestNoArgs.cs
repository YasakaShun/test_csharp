using System;

namespace SelfCSharp.Chap08.Destruct
{
    class MyParent
    {
        ~MyParent()
        {
            Console.WriteLine("親です。");
        }
    }

    class MyChild : MyParent
    {
        ~MyChild()
        {
            Console.WriteLine("子です。");
        }
    }

    class DestNoArgs
    {
        static void Main(string[] args)
        {
            var c = new MyChild();
        }
    }
}
