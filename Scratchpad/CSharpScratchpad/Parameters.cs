using System;

namespace CSharpScratchpad
{
	public class Parameters
	{
		public Parameters ()
		{
		}

		public void Run ()
		{
			//Passing by value:
			int someValue = 3;
			passByValue (someValue);
			Console.Out.WriteLine ("Original 3 => " + someValue);

			//Passing by reference:
			int otherValue = 4;
			passByReference (ref otherValue); //Important: "ref", otherwise compiletime error.
			Console.Out.WriteLine ("Original 4 => " + otherValue);

			//The out modifier:
			string result, result2;
			outModifierExample ("foo", out result, out result2);
			Console.Out.WriteLine (result + "  " + result2);
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
	}
}

