using System;
using System.Collections;
using System.Collections.Generic;

public class CityCollection
{
    private string[] m_Cities = { "Bern", "Basel", "Genf" };
    bool reverse = false;

    public IEnumerator GetEnumerator()
    {
        for (int i = 0; i < m_Cities.GetLength(0); i++)
        {
            yield return m_Cities.GetValue(i);
        }
    }

    public IEnumerator ReverseIEnum()
    {
        for (int i = m_Cities.GetLength(0); i > 0; i--)
        {
            yield return m_Cities.GetValue(i);
        }
    }

    //TODO: HERE
    public IEnumerable<string> Reverse
    {
        get;
        set;
    }
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
