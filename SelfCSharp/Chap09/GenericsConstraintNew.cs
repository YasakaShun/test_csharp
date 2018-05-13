using System;

namespace SelfCSharp.Chap09.GenericsConst
{
    class MyGenerics<T> where T : new()
    {
        public void Hoge()
        {
            var value = new T();
        }
    }

    class GenericsConstraintNew
    {
        static void Main(string[] args)
        {
            var m = new MyGenerics<int>();
        }
    }
}
