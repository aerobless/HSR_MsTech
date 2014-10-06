using System;
using System.Collections.Generic;
using System.Text;

public class Person : IComparable
{
    string name;
    int age;

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

        Console.WriteLine("Done: Press any key to exit");
        Console.Read();
    }
}

