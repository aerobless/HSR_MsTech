using System;

namespace Something
{
	public class AnonDelegateWithLambda
	{
		public AnonDelegateWithLambda ()
		{
		}

		public void Run ()
		{
			var anon = new AnonDelegateWithLambda ();
			var adder = anon.CreateAdder (5);
			Console.WriteLine ("{0} : {1}", adder (3), anon.Count);
			Console.WriteLine ("{0} : {1}", adder (4), anon.Count);
		}

		private int count = 0;

		public int Count {
			get { return count; }
			//private is ok, because we access from inside the same class
			private set { count = value; }
		}

		public Func<int, int> CreateAdder (int summand)
		{
			return s => {
				Count++;
				return s + summand;
			};
		}

	}
}

