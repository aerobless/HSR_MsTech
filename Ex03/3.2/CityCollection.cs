using System;
using System.Collections;
using System.Collections.Generic;

public class CityCollection
{
    private string[] m_Cities = { "Bern", "Basel", "Genf" };

    public IEnumerator GetEnumerator()
    {
        for (int i = 0; i < m_Cities.GetLength(0); i++)
        {
            yield return m_Cities.GetValue(i);
        }
    }

    public IEnumerable Reverse()
    {
        for (int i = (m_Cities.GetLength(0)-1); i > -1; i--)
        {
            yield return m_Cities.GetValue(i);
        }
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
        Console.WriteLine("\nReverse Output:");
        //Ausgabe in umgekehrter Reihenfolge 
        foreach (string s in myColl.Reverse())
        {
            Console.WriteLine(s);
        }
        
        Console.WriteLine("\nPress Enter to Exit");
        Console.ReadLine();
    }
}