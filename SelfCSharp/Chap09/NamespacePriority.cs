using System;

using SelfCSharp.Chap09.Priority1;
using MyUtil = SelfCSharp.Chap09.Priority2.MyUtil;

namespace SelfCSharp.Chap09.Priority1
{
    class MyUtil
    {
        public static void Run()
        {
            Console.WriteLine("Priority1名前空間");
        }
    }
}

namespace SelfCSharp.Chap09.Priority2
{
    class MyUtil
    {
        public static void Run()
        {
            Console.WriteLine("Priority2名前空間");
        }
    }
}

namespace SelfCSharp.Chap09.Priority3
{
    class MyUtil
    {
        public static void Run()
        {
            Console.WriteLine("Priority3名前空間");
        }
    }
}

    //class MyUtil
    //{
    //    public static void Run() {
    //        Console.WriteLine("グローバル名前空間");
    //    }
    //}


namespace SelfCSharp.Chap09.Priority
{
    using SelfCSharp.Chap09.Priority3;

    class MyUtil
    {
        public static void Run()
        {
            Console.WriteLine("現在の名前空間");
        }
    }

    class NamespacePriority
    {
        static void Main(string[] args)
        {
            MyUtil.Run();
        }
    }
}