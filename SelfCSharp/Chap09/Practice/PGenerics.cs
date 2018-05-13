namespace SelfCSharp.Chap09.Practice
{
    class MyGenerics<T> where T : new()
    {
        T obj = new T();
    }

    class PGenerics
    {
        static void Main(string[] args)
        {
            var m = new MyGenerics<int>();
        }
    }
}
