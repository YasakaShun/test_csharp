using System;
//using static SelfCSharp.Chap09.MyClass;

namespace SelfCSharp.Chap09.Nested
{
    class MyClass
    {
        class MyHelper
        //public class MyHelper
        {
            public void Show()
            {
                Console.WriteLine("Nested Class is running!");
            }
        }

        public void Run()
        {
            var helper = new MyHelper();
            helper.Show();
        }
    }

    class NestedBasic
    {
        static void Main(string[] args)
        {
            var c = new MyClass();
            c.Run();

            //var h = new MyClass.MyHelper();
            
            //var h = new MyHelper();
        }
    }
}
