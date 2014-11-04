using System;
using System.Drawing;
using MonoMac.Foundation;
using MonoMac.AppKit;
using MonoMac.ObjCRuntime;

namespace CSharpScratchpad
{
	class MainClass
	{
		static void Main (string[] args)
		{
			Parameters parameters = new Parameters ();
			parameters.Run ();

			Various various = new Various ();
			various.Run ();

			Classes classes = new Classes ();
			classes.Run ();

		}
	}
}

