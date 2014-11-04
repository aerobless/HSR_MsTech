using System;

namespace CSharpScratchpad
{
	public class Various
	{
		public Various ()
		{
		}

		public void Run ()
		{
			//Why? I just wanted to use goto once in my live!
			gotoExample ();


		}

		static void gotoExample ()
		{
			int i = 0;
			gotoMarker:
			if (i == 0) {
				goto gotoMarker;
			} else {
				Console.Out.WriteLine ("omg!");
			}
		}
	}
}

