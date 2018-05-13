﻿using IronPython.Hosting;
using System;

namespace SelfCSharp.Chap11
{
    class PythonCall
    {
        static void Main(string[] args)
        {
            var py = Python.CreateRuntime();
            dynamic script = py.UseFile("Chap11/myClass.py");
            dynamic clazz = script.MyClass();
            Console.WriteLine(clazz.greet("山田"));

            //py.UseFile("Chap11/hello.py");
        }
    }
}
