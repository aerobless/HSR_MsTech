using System;

// Achtung: Vorgabe kompiliert nicht 
namespace IteratorVorgabe
{
    class Program
    {
        static void Main(string[] args)
        {
            RecList<string> list = new RecList<string>();
            list.Append("Hallo");
            list.Append(".NET");
            list.Append("C#");
            list.Append("---");

            //Iteriere über die Liste 
            // -- todo: List.Traverse implementieren
            foreach (string s in list.Traverse)
            {
                Console.WriteLine(s);
            }

            //Iteriere über die Liste im umgekehrter Reihenfolge
            //-- todo: List.Traverse implementieren
            foreach (string s in list.Inverse)
            {
                Console.WriteLine(s);
            }

            //Test mit leerer liste
            RecList<string> list1 = new RecList<string>();
            foreach (string s in list1.Traverse)
            {
                Console.WriteLine(s);
            }
            foreach (string s in list1.Inverse)
            {
                Console.WriteLine(s);
            }

            //Foreach Test
            Console.WriteLine("Foreach-test");
            //-- todo: List.ForEach implementieren
            //list.ForEach . . .
            //    Console.ReadLine();

            Console.WriteLine("Press Enter to Exit");
            Console.ReadLine();
        }
    }
}

