using System;
using System.Collections.Generic;
using System.Text;

public class Person : IComparable
{
    string name;
    public int age;

    public Person(string s, int i)
    {
        name = s;
        age = i;
    }

    public int CompareTo(object p)
    {
        Person pers = p as Person;
        if (pers != null)
        {
            return age - pers.age;
        }
        else throw new Exception("p has wrong type");
    }

    public override string ToString()
    {
        return name + ":" + age;
    }
}

class Test
{
    static void Main(string[] args)
    {
        //Exercise 1.1
        SortedList<Person> list = new SortedList<Person>();
        //Create name and age values to initialize Person objects.
        string[] names = new string[] { "Franscoise", "Bill", "Li", "Sandra", "Gunnar", "Alok", "Hiroyuki", "Maria", "Alessandro", "Raul" };
        int[] ages = new int[] { 45, 19, 28, 23, 18, 9, 108, 72, 30, 35 };

        //Populate the list.
        for (int x = 0; x < names.Length; x++)
        {
            list.Add(new Person(names[x], ages[x]));
        }

        Console.WriteLine("Unsorted List:");
        //Print out unsorted list.
        foreach (Person p in list)
        {
            Console.WriteLine(p.ToString());
        }

        //Sort the list.
        list.BubbleSort();

        Console.WriteLine("Sorted List:");
        //Print out sorted list.
        foreach (Person p in list)
        {
            Console.WriteLine(p.ToString());
        }

        Console.WriteLine("\n \nEXERCISE 1.2");

        //Exercise 1.2
        // ToDo: Definiere die typsichere Personen-Liste list
        List<Person> list2 = new List<Person>();

        //Create name and age values to initialize Person objects.
        string[] names2 = new string[] { "Li", "Sandra", "Gunnar", "Alok", "Hiroyuki" };
        int[] ages2 = new int[] { 28, 23, 18, 9, 108 };
        //Populate the list.
        for (int x = 0; x < names2.Length; x++)
        {
            list2.Add(new Person(names2[x], ages2[x]));
        }
        // ToDo: Sortiere die Liste nach dem Personennamen,
        // Die Definition von Person darf nicht geändert werden
        // Verwenden Sie dazu die statische Methode ComparePersonsByName
        Console.WriteLine("\n---Part1---");
        list2.Sort(ComparePersonsByName);
        list2.ForEach(Console.WriteLine);

        // ToDo: Geben Sie die Liste der Personen aus, deren Alter>=30 ist.
        // Verwenden Sie dazu ausschliesslich List.FindAll und List.ForEach.
        // Implementieren Sie den Vergleich als anonymes Delegate.
        Console.WriteLine("\n---Part2---");
        list2 = list2.FindAll(i => i.age>30);
        list2.ForEach(Console.WriteLine);

        Console.WriteLine("\nDone: Press any key to exit");
        Console.Read();
    }

    private static int ComparePersonsByName(Person p1, Person p2)
    {
        // ToDo: Implementieren Sie die benötigte Funktionalität.
        // Reagieren Sie adäquat auf alle möglichen Fehlerfälle.
        return p1.CompareTo(p2);
    }
}

