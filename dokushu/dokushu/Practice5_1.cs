using System;

namespace dokushu
{
    class Practice5_1
    {

        public static void Exec1()
        {
            var str = "プログラミング言語";
            Console.WriteLine(str.Substring(str.IndexOf("ミング"), 3));
        }

        public static void Exec2()
        {
            var str = "鈴木\t太郎\t男\t50歳\t広島県";
            var ary = str.Split('\t');
            foreach (var s in ary)
            {
                Console.WriteLine(s);
            }
        }
    }
}