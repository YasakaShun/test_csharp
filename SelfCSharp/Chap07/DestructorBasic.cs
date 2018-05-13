using System;

namespace SelfCSharp.Chap07.Destruct
{
    class MyProcess
    {        
        public MyProcess()
        {
            Console.WriteLine("constructor");
        }

        ~MyProcess()
        {
            Console.WriteLine("destructor");
        }
    }

    class DestructorBasic
    {
        static void Main(string[] args)
        {
            var mp = new MyProcess();
        }
    }
}
