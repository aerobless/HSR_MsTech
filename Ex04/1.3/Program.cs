using System;
using System.Collections.Generic;

namespace ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] cities = new[] {"Bern", "Zürich", "Genf"};

            Console.WriteLine("ForEachElem / Cities");
            cities.ForEachElem(s => Console.WriteLine(s));

            Console.WriteLine("ForEachElem / Cities (Upper-Case)");
            cities.ForEachElem(s => Console.WriteLine(s.ToUpper()));

            Console.WriteLine("Press key to exit");
            Console.ReadKey();
        }
    }
}
