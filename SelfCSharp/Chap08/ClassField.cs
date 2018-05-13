﻿using System;

namespace SelfCSharp.Chap08.PublicField
{
    class Triangle
    {
        public double width;
        public double height;

        public double GetArea()
        {
            return this.width * this.height / 2;
        }
    }

    class ClassField
    {
        static void Main(string[] args)
        {
            var t = new Triangle();
            t.width = 10;
            t.height = 5;
            Console.WriteLine(t.GetArea());
        }
    }
}
