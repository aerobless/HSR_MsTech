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

            Expression<Func<int, bool>> f1 = n => n < 5;
            PrintExpressionTree(filter);

          ///  Console.WriteLine("f(1) = {0}", f(1));
           // Console.WriteLine("f(2) = {0}", f(2));

            Console.ReadLine();
        }

        private static void PrintExpressionTree(Expression<Func<int, bool>> filter)
        {
            BinaryExpression body = (BinaryExpression)filter.Body;
            ParameterExpression left = (ParameterExpression)body.Left;
            ConstantExpression right = (ConstantExpression)body.Right;
            Console.WriteLine("{0} {1} {2}",
            left.Name, body.NodeType, right.Value);
        }
    }
}
