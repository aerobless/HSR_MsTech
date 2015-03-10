using System;

namespace Something
{
	public class Parameters
	{
		public Parameters ()
		{
		}

		public void Run ()
		{
			//Passing by value: (normal case)
			int someValue = 3;
			passByValue (someValue);
			Console.Out.WriteLine ("Original 3 => " + someValue);

			//Passing by reference:
			int otherValue = 4;
			passByReference (ref otherValue); //Important: "ref", otherwise compiletime error.
			Console.Out.WriteLine ("Original 4 => " + otherValue);

			//The out modifier:
			string result, result2;
			outModifierExample ("foo", out result, out result2); //Important: "out", otherwise compiletime error.
			Console.Out.WriteLine (result + "  " + result2);

			//Optional parameter:
			optionalParameter (34);
			optionalParameter ();

			//Named parameters:
			namedParameter ();
			namedParameter (y: 4, x: 2);
			namedParameter (z: 500);
		}

		private void passByValue (int x)
		{
			++x;
			Console.Out.WriteLine ("x+1=" + x);
		}

		private void passByReference (ref int x)
		{
			++x;
			Console.Out.WriteLine ("x+1=" + x);
		}

		private void outModifierExample (string test, out string result, out string result2)
		{
			result = test + "bar1";
			result2 = test + "bar2";
		}

		private void optionalParameter (int x = 24)
		{
			if (x == 24) {
				Console.Out.WriteLine ("Default param 24 used.");
			} else {
				Console.Out.WriteLine ("Optional param " + x + " used.");
			}
		}

		private void namedParameter (int x = 1, int y = 2, int z = 3)
		{
			Console.Out.WriteLine ("X:" + x + " Y:" + y + " Z:" + z);
		}
	}
}

