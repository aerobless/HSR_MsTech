using System;
using System.Collections.Generic;
using System.Linq;

namespace LambdaExpressions1
{
    class Program
    {
        static void Main(string[] args)
        {
            var fruits = new Dictionary<string, double>();

            fruits.Add("banana", 1.03);
            fruits.Add("cherry", 2.55);
            fruits.Add("apple", 1.00);
            fruits.Add("blueberry", 0.80);

            var matches = /* to do */
            Console.WriteLine("Number of matches: {0}", matches.Count);

            Console.WriteLine("Sum of matches: {0}", /* to do */);
            Console.WriteLine("Names of matches: {0}", /* to do */);

            Console.WriteLine("Press key to exit");
            Console.ReadKey();
        }
    }
}
