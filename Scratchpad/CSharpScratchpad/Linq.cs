using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace CSharpScratchpad
{
	public class Kunde
	{
		public int KId { get; set; }

		public string Name { get; set; }
	}


	public class Bestellung
	{
		private List<BestellItem> items = new List<BestellItem> ();

		public int BId { get; set; }

		public string Datum { get; set; }

		public List<BestellItem> Items { get { return items; } }

		public int KId { get; set; }

		public void AddItem (BestellItem item)
		{
			Items.Add (item);
		}
	}

	public class BestellItem
	{
		public int Anzahl { get; set; }

		public int BId { get; set; }

		public int IId { get; set; }

		public double Preis { get; set; }

		public string Produkt { get; set; }
	}

	public class Linq
	{
		public Linq ()
		{
			/*
			var kunden = new Kunde[] {
				new Kunde () { KId = 1, Name = "Muster" },
				new Kunde () { KId = 2, Name = "Schneider" }
			};

			var bestellungen = new List<Bestellung> ();
			Bestellung best = new Bestellung () { BId = 100, Datum = "11-Jan-09", KId = 1 };
			best.AddItem (new BestellItem () {
				IId = 1,
				Produkt = "Schraube",
				Anzahl = 100,
				Preis = 12.5F
			});
			best.AddItem (new BestellItem () {
				IId = 2,
				Produkt = "Mutter",
				Anzahl = 100,
				Preis = 2.5F
			});
			bestellungen.Add (best);
			best = new Bestellung () { BId = 101, Datum = "12-Jan-09", KId = 1 };
			best.AddItem (new BestellItem () { IId = 1, Produkt = "Unterlagscheibe", Anzahl = 100, Preis = 1.5F });
			bestellungen.Add (best);
			best = new Bestellung () { BId = 103, Datum = "12-Jan-09", KId = 2 };
			best.AddItem (new BestellItem () { IId = 1, Produkt = "Nagel", Anzahl = 500, Preis = 8.5F });
			best.AddItem (new BestellItem () {
				IId = 2,
				Produkt = "Haken",
				Anzahl = 400,
				Preis = 4.1F
			});
			bestellungen.Add (best);
			best = new Bestellung () { BId = 104, Datum = "13-Jan-09", KId = 2 };
			best.AddItem (new BestellItem () { IId = 1, Produkt = "Hammer", Anzahl = 5, Preis = 25.5F });
			bestellungen.Add (best);
			best = new Bestellung () { BId = 105, Datum = "14-Jan-09", KId = 2 };
			best.AddItem (new BestellItem () { IId = 1, Produkt = "Zange", Anzahl = 5, Preis = 55.5F });
			best.AddItem (new BestellItem () {
				IId = 2,
				Produkt = "Schraubenzieher",
				Anzahl = 10,
				Preis = 35.4F
			});
			bestellungen.Add (best);
			Console.WriteLine ("dd");

*/
			string[] fullNames = { "Fritz Jakob Müller", "Gabi Keller" };

			IEnumerable<string> query = fullNames
				.SelectMany (fName => fName.Split ().Select (name => new { name, fName }))
				.OrderBy (x => x.fName)
				.ThenBy (x => x.name)
				.Select (x => x.name + " came from " + x.fName);
				
			Console.WriteLine ("dd");
			Console.WriteLine (query);
		}
	}
}

