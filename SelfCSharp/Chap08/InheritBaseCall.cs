using System;

namespace SelfCSharp.Chap08
{
    class EliteBusinessPerson : BusinessPerson
    {
        public new string Work()
        {
            var result = base.Work();
            return $"{result}いつでもテキパキと";
        }
    }

    class InheritBaseCall
    {
        static void Main(string[] args)
        {
            var ep = new EliteBusinessPerson {
                FirstName = "太郎",
                LastName = "山田"
            };
            Console.WriteLine(ep.Work());
        }
    }
}
