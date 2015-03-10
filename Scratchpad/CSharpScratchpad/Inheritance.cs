using System;
using System.Collections;

namespace Something
{
	public class Inheritance
	{
		public Inheritance ()
		{
		}

		public void Run ()
		{
			Base a = new A ();
			a.Foo ();
			a.Foo2 ();
			((A)a).Foo ();
			((A)a).Foo2 ();	
		}

		public static void printList (ArrayList l)
		{
			System.Console.WriteLine ("elements in list:");
			foreach (TestType o in l) {
				System.Console.WriteLine ("{0}", o.i);
			}
		}

		public static void Test ()
		{
			ArrayList myList = new ArrayList ();
			//string o1 = new string ("1");
			//string o2 = new string ("2");
			TestType o1 = new TestType (1);
			TestType o2 = new TestType (2);
			myList.Add (o1);
			myList.Add (o2);
			printList (myList);
			o2 = new TestType (4);
			//Object o2 = (Object) 4;
			printList (myList);
		}
	}

	public class TestType
	{
		public TestType (int i)
		{
			this.i = i;
		}

		public int i { get; set; }

	}

	public class Base
	{
		public virtual void Foo1 ()
		{
			Console.WriteLine ("Base.Foo1");
		}

		public void Foo2 ()
		{
			Console.WriteLine ("Base.Foo2");
		}

		public void Foo ()
		{
			Foo1 ();
			Foo2 ();
		}
	}

	public class  A : Base
	{
		public override void Foo1 ()
		{
			Console.WriteLine ("A.Foo1");
		}

		public new void Foo2 ()
		{
			Console.WriteLine ("A.Foo2");
		}
	}
}