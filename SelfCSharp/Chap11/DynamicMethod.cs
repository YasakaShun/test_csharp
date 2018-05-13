using System;
using System.Collections.Generic;
using System.Dynamic;

namespace SelfCSharp.Chap11.DynamicProcess
{
    class FreeMember : DynamicObject
    {

        private Dictionary<string, object> items;

        public FreeMember()
        {
            items = new Dictionary<string, object>();
        }


        public override bool TryInvokeMember(InvokeMemberBinder binder,
          object[] args, out object result)
        {
            result = null;

            if (args.Length == 0)
            {
                items.TryGetValue(binder.Name, out result);                
            }
            else
            {
                items[binder.Name] = args[0];
            }
            return true;
        }
    }


    class DynamicMethod
    {
        static void Main(string[] args)
        {
            dynamic d = new FreeMember();
            d.Count(1);
            d.Name("山田");
            Console.WriteLine(d.Count());
            Console.WriteLine(d.Name());
        }
    }
}
