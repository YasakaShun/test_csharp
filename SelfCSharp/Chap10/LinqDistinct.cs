using System;
using System.Linq;

namespace SelfCSharp.Chap10
{
    class LinqDistinct
    {
        static void Main(string[] args)
        {
            //var bs = (from b in AppTables.Books
            //          select b.Publisher).Distinct();


            //メソッド構文
            var bs = AppTables.Books
                     .Select(b => b.Publisher)
                     .Distinct();

            foreach (var b in bs)
            {
                Console.WriteLine(b);
            }
        }
    }
}
