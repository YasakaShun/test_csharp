﻿using System;
using System.IO;

namespace SelfCSharp.Chap09
{
    class TryCatchOrder
    {
        static void Main(string[] args)
        {
            try
            {
                using (StreamReader sr = new StreamReader(@"C:\nothing.dat"))
                {
                    Console.WriteLine(sr.ReadToEnd());
                }
            }
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.StackTrace);
            //}
            catch (ArgumentNullException ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
        }
    }
}
