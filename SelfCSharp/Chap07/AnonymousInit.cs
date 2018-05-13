using System;

namespace SelfCSharp.Chap07.Anonymous
{
    class Hoge
    {
        public string value = "field";

        public Hoge() { }

        public Hoge(string value)
        {
            this.value = value;
        }
    }

    class AnonymousInit
    {
        static void Main(string[] args)
        {
            var h = new Hoge("constructor") { value = "initializer" };

            Console.WriteLine(h.value);
        }
    }
}
