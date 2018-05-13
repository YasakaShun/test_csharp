using System;

namespace SelfCSharp.Chap08.OverrideNg
{
    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public virtual string Show()
        {
            return $"名前は{this.LastName}{this.FirstName}です。";

        }
    }

    class BusinessPerson : Person
    {
        public sealed override string Show()
        {
            return $"会社員の{this.LastName}{this.FirstName}です。";
        }
    }

    class EliteBusinessPerson : BusinessPerson
    {
        //public override string Show()
        //{
        //    return $"エリートな会社員の{this.LastName}{this.FirstName}です。";
        //}
    }


    class MethodNoOverride
    {
        static void Main(string[] args)
        {
            var ep = new EliteBusinessPerson
            {
                FirstName = "太郎",
                LastName = "山田"
            };
            Console.WriteLine(ep.Show());
        }
    }
}
