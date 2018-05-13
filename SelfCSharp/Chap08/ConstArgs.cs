using System;

namespace SelfCSharp.Chap08.Construct
{
    class MyParent
    {
        public MyParent(string childName)
        {
            Console.WriteLine($"{childName}の親です。");
        }
    }

    class MyChild : MyParent
    {
        //public MyChild(string childName)
        public MyChild(string childName) : base(childName)
        {
            Console.WriteLine($"子の{childName}です。");
        }
    }

    class ConstArgs
    {
        static void Main(string[] args)
        {
            var c = new MyChild("花子");            
        }
    }
}
