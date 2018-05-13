using System;
using System.Collections.Generic;

namespace dokushu
{
    class Test6
    {
        public static void Exec2()
        {
            var dic = new Dictionary<string, string>()
            {
                ["lettuce"] = "レタス",
                ["spinach"] = "ほうれんそう",
                ["cucumber"] = "きゅうり",
            };

            dic["cucumber"] = "胡瓜";
            dic.Add("cabbage", "キャベツ");
            dic.Remove("spinach");

            foreach (var m in dic)
            {
                Console.WriteLine($"{m.Key}: {m.Value}");
            }
        }

        public static void Exec3()
        {
            var list = new List<int>() { 1, 2, 3, 4 };
            list[2] = 50;
            list.Insert(1, 5);
            list.Remove(60);

            foreach (int v in list)
            {
                Console.WriteLine(v);
            }
        }
    }
}