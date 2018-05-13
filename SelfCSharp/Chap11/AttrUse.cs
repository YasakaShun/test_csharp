using System;

namespace SelfCSharp.Chap11
{
    [Version("1.0.0", Beta = true)]
    class AttrUse
    {
        public static void Main(string[] args)
        {
            var t = typeof(AttrUse);
            var attr = Attribute.GetCustomAttribute(
              t, typeof(VersionAttribute)) as VersionAttribute;
            Console.WriteLine(attr.Number);
            Console.WriteLine("β版で" + (attr.Beta ? "す" : "はありません"));

            //if (Attribute.IsDefined(t, typeof(VersionAttribute)))
            //{
            //    Console.WriteLine("Version属性が存在します");
            //}
        }
    }
}
