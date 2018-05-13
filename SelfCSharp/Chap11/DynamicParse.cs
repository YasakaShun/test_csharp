using Codeplex.Data;
using System;

namespace SelfCSharp.Chap11
{
    class DynamicParse
    {
        static void Main(string[] args)
        {
            var json = DynamicJson.Parse(
                @"{""title"":""速習C#"", ""min-price"":1000, 
                    ""sample"":{""dl"":true},
                    ""authors"":[""山田太郎"", ""鈴木次郎""]");

            Console.WriteLine(json.title);
            Console.WriteLine(json.sample.dl);
            Console.WriteLine(json.authors[1]);
            Console.WriteLine(json["min-price"]);
            //Console.WriteLine(json.book);

            if (json.IsDefined("book"))
            {
                Console.WriteLine(json.book);
            }            
        }
    }
}
