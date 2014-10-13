using System;
using System.Collections.Generic;
using System.Linq;

namespace ExtensionMethods
{
    public class Test
    {
        static void Main()
        {
            Console.WriteLine("TestWhere");
            TestWhere();

            Console.WriteLine("\nTestWhereLINQ Query Expression");
            TestWhereQueryLinq();

            Console.WriteLine("\nTestOfType");
            TestOfType();
            
            Console.WriteLine("\nTestAggregateSum");
            TestAggregateSum();
            
            Console.ReadLine();
        }
        
        private static void TestWhere()
        {
            string[] names = { "1234567","Burke", "Connor", "Frank", "Everett", "Albert", "George", "Harris", "David" };

            IEnumerable<string> query = Extensions.HSRWhere(names, s => s.Length < 6);
            //However, what makes extension methods unique is that they can also be invoked using instance syntax:
            IEnumerable<string> query1 = names.HSRWhere(s => s.Length < 6);
            query1.HSRForEach(s => Console.WriteLine(s));
            Console.Out.WriteLine("\n");
            //oder
            names.HSRWhere(s => s.Length < 6)
                 .HSRForEach(s => Console.WriteLine(s));

            Console.Out.WriteLine("\n");
            //oder eager
            names.HSRWhere(s => s.Length < 6)
                .ToList()
                .HSRForEach(s => Console.WriteLine(s));
        }

        private static void TestWhereQueryLinq()
        {
            string[] names = { "1234567", "Burke", "Connor", "Frank", "Everett", "Albert", "George", "Harris", "David" };
            IEnumerable<string> query1 =
                from item in names
                where item.Length < 6
                select item;
            query1.HSRForEach(s => Console.WriteLine(s));
        }
        private static void TestOfType()
        {
            object[] objs = { 1, "Burke", true, "Everett", 7.9, "Albert" };
            IEnumerable<string> query1 = objs.HSROfType<string>();
            query1.HSRForEach(s => Console.WriteLine(s));

        }
        
        private static void TestAggregateSum()
        {
            string[] names = { "Albert", "Burke", "Connor", "David", "Everett", "Frank", "George", "Harris"};

            int count = names.HSRAggregate(0, (c, s) => c + s.Length);
            Console.Out.WriteLine(count);
            // count == 46

            count = names.HSRSum(c => c.Length);
            Console.Out.WriteLine(count);
            //und jetzt mit Ling Namespace
            count = names.Aggregate(0, (c, s) => c + s.Length);
            Console.Out.WriteLine(count);
            // count == 46
            count = names.Sum(c => c.Length);
            Console.Out.WriteLine(count);
        }
    }
}
