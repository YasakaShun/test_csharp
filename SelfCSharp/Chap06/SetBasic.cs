﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace SelfCSharp.Chap06
{
    class SetBasic
    {
        static void PrintSet<T>(HashSet<T> set)
        {
            Console.WriteLine(String.Join(",", set.ToArray()));
        }

        static void Main(string[] args)
        {
            var hs = new HashSet<int> { 1, 20, 30, 60, 10, 15 };
            hs.Add(10);
            hs.Add(5);
            hs.Remove(60);

            foreach (var v in hs)
            {
                Console.WriteLine(v);
            }

            Console.WriteLine(hs.Count);
            Console.WriteLine(hs.Contains(10));

            var hs2 = new HashSet<int> { 10, 15, 30 };
            Console.WriteLine(hs.IsSupersetOf(hs2));
            Console.WriteLine(hs.IsProperSupersetOf(hs2));
            Console.WriteLine(hs.IsSubsetOf(hs2));
            Console.WriteLine(hs.IsProperSubsetOf(hs2));
            Console.WriteLine(hs.Overlaps(hs2));
            Console.WriteLine(hs.SetEquals(hs2));

            var hs3 = new HashSet<int> { 1, 10, 20, 30, 60 };
            PrintSet(hs);
            hs.IntersectWith(hs3);
            PrintSet(hs);

            var hs4 = new HashSet<int> { 15, 30 };
            hs.ExceptWith(hs4);
            PrintSet(hs);

            hs.UnionWith(hs2);
            PrintSet(hs);
        }
    }
}
