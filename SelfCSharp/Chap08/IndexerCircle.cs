using System;

namespace SelfCSharp.Chap08
{
    class Circle
    {
        public double this[double radius]
        {
            get
            {
                return radius * radius * Math.PI;
            }
        }
    }

    class IndexerCircle
    {
        static void Main(string[] args)
        {
            var c = new Circle();
            Console.WriteLine(c[10]);
        }
    }
}
