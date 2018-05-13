using System;
using System.Linq;

namespace SelfCSharp.Chap10
{
    class LinqLike
    {
        static void Main(string[] args)
        {
            //クエリ構文
            var bs = from b in AppTables.Books
                     where b.Title.Contains("アプリ")
                     //where !b.Title.Contains("アプリ")
                     select b;


            //メソッド構文
            //var bs = AppTables.Books
            //       .Where(b => b.Title.Contains("アプリ"))
            //       //.Where(b => !b.Title.Contains("アプリ"))
            //       .Select(b => b);

            foreach (var b in bs)
            {
                Console.WriteLine(b);
            }
        }
    }
}
