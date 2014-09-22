using System;
using System.Diagnostics;

/// <summary>
/// Einfacher Referenztyp für das Rechnen mit Bruechen 
/// </summary>
class Fraction : IComparable
{
	public int a, b;
	public Fraction(int a, int b) { this.a = a; this.b = b; }
	// Überladene Methode System.Object.ToString
	public override string ToString() { return a + "/" + b; }

	public int CompareTo(object o) 
	{
		Fraction f2 = (Fraction)o;
		float fract1 = (float)this.a / this.b;
		float fract2 = (float)f2.a / f2.b;
		if (fract1 < fract2) return -1;
		else if (fract1 > fract2) return 1;
		else return 0;
	}
}

class Program 
{ 
	public static void Main() 
	{
		Fraction[] a = { new Fraction(1,2), new Fraction(3,4), new Fraction(4,8), new Fraction(8,3)};
		string[] b = {"pears", "apples", "oranges", "bananas", "plums"};

        // TODO:
        // Sortieren Sie den Array a mit der Array.Sort-Methode
		Array.Sort(a);

		// Ausgabe des sortierten Arrays a
		foreach (Fraction f in a) Console.Write(f + " ");
		Console.WriteLine();

        // TODO:
        // Sortieren Sie den Array b mit der Array.Sort-Methode
		Array.Sort(b);
		
		//Ausgabe des sortierten Arrays b
		foreach (string s in b) Console.Write(s + " ");
		Console.WriteLine();
		
		Console.WriteLine("Press Enter to Exit");
		Console.ReadLine();
	}
}

