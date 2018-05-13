using System;
using System.Linq;

namespace SelfCSharp.Chap10
{
    class LinqStartsWith
    {
        static void Main(string[] args)
        {
            //クエリ構文
            var bs = from b in AppTables.Books
                     where b.Title.StartsWith("アプリ")
                     select b;

            //メソッド構文
            //var bs = AppTables.Books
            //        .Where(b => b.Title.StartsWith("アプリ"))
            //        .Select(b => b);

            foreach (var b in bs)
            {
                Console.WriteLine(b);
            }
        }
    }
}
