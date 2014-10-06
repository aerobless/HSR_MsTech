using System;
using System.Collections;
using System.Collections.Generic;

public class CityCollection
{
    private string[] m_Cities = { "Bern", "Basel", "Genf" };
}
class Test
{
    public static void Main()
    {
        CityCollection myColl = new CityCollection();
        foreach (string s in myColl)
        {
            Console.WriteLine(s);
        }
        //Ausgabe in umgekehrter Reihenfolge 
        foreach (string s in myColl.Reverse)
        {
            Console.WriteLine(s);
        }

        Console.WriteLine("Press Enter to Exit");
        Console.ReadLine();
    }
}
