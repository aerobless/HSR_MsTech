using System;

namespace ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = "string abc";
            Console.WriteLine(a.SafeToString()); // Resultat a.ToString()
            a = null;
            Console.WriteLine(a.SafeToString()); //Resultat “null”

            Console.WriteLine("Press key to exit");
            Console.ReadKey();
        }
    }
}
