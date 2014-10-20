using System;
using AdventureWorksLibrary;

namespace AdventureWorksConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            using (AdventureWorksLTEntities db = new AdventureWorksLTEntities())
            {
                var products = db.Products;
                foreach (var product in products)
                {
                    Console.WriteLine("Type: {0}\t Product Name: {1}",
                    product.GetType().Name,
                    product.Name);
                }
                Console.ReadLine();
            }
        }
    }
}
