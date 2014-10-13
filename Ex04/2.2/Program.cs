using System;
using System.Linq.Expressions;

namespace LambdaExpression2
{
    class Program
    {
        static void Main(string[] args)
        {
            Expression<Func<int, bool>> filter = n => (n * 3) < 5;

            /* to do */

            Func<int, bool> f;

            Console.WriteLine("f(1) = {0}", f(1));
            Console.WriteLine("f(2) = {0}", f(2));
        }
    }
}
