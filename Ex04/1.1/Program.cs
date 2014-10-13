using System;

namespace ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] identifiers = new string[] { 
 		     "do_something", 
 		     "find_all_objects", 
  		     "get_last_dict_entry" 
 		    };

            foreach (string s in identifiers)
                Console.WriteLine("{0} becomes: {1}", s, Extensions.CamelCase(s));
            foreach (string s in identifiers)
                Console.WriteLine("{0} becomes: {1}", s, s.CamelCase());

            Console.WriteLine("Press key to exit");
            Console.ReadKey();
        }
    }
}
