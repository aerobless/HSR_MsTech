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
                // ...
            }
        }
    }
}
