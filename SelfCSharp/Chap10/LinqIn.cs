using System;
using System.Linq;

namespace SelfCSharp.Chap10
{
    class LinqIn
    {
        static void Main(string[] args)
        {
            //クエリ構文
            var bs = from b in AppTables.Books
                     where (new int[] { 1, 4 }.Contains(b.Published.Month))
                     select (b);


            //メソッド構文
            //var bs = AppTables.Books
            //        .Where(b => new int[] { 1, 4 }.Contains(b.Published.Month))
            //        .Select(b => b);

            foreach (var b in bs)
            {
                Console.WriteLine(b);
            }
        }
    }
}
