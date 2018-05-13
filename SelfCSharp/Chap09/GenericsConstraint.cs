using System;

namespace SelfCSharp.Chap09
{
    class MyGenerics<T> where T : IComparable<T>
    {
        public int Hoge(T x, T y)
        {
            return x.CompareTo(y);
        }
    }

    class GenericsConstraint
    {
        static void Main(string[] args)
        {
            var m = new MyGenerics<string>();
            Console.WriteLine(m.Hoge("あいう", "あいう"));
        }
    }
}
