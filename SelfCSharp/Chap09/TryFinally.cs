﻿using System;
using System.IO;

namespace SelfCSharp.Chap09
{
    class TryFinally
    {
        static void Main(string[] args)
        {
            StreamReader sr = null;
            try
            {
                sr = new StreamReader(@"C:\nothing.dat");
                Console.WriteLine(sr.ReadToEnd());
            }
            finally
            {                
                if (sr != null)
                {
                    sr.Close();
                }
            }
        }
    }
}
