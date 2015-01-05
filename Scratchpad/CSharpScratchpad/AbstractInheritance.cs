using System;

namespace CSharpScratchpad
{
	public class AbstractInheritance
	{
		public AbstractInheritance ()
		{
		}

		public void Run ()
		{
			Shape c1 = new Circle ();
			Shape c2 = new Circle ();
			Shape l1 = new Line ();
			Shape l2 = new Line ();

			l1.Intersect (l2);
			l1.Intersect (c1);
			c1.Intersect (l2);
			c2.Intersect (c1);
		}
	}

	public abstract class Shape
	{
		public abstract void Intersect (Shape s);
	}

	public class Circle : Shape
	{
		public override void Intersect (Shape s)
		{
			Console.WriteLine ("Circle intersects " + s.GetType ());
		}
	}

	public class Line : Shape
	{
		public override void Intersect (Shape s)
		{
			Console.WriteLine (this.GetType () + " intersects " + s.GetType ());
		}

	}

}

