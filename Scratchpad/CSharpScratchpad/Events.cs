using System;

namespace CSharpScratchpad
{
	//1. Delegate aka EventHandler
	public delegate void SomethingsChangedHandler (string what);

	public class Something
	{
		string somethingLocal;

		//2. Event
		public event SomethingsChangedHandler SomethingsChanged;

		public Something ()
		{
		}

		public void changeSomething (string something)
		{
			somethingLocal = something;
			//3. Fire Event
			if (SomethingsChanged != null) {
				SomethingsChanged (somethingLocal);
			}
		}
	}

	public class EventTest
	{
		public EventTest ()
		{
			Something theEvent = new Something ();
			//4. Listen to the event
			theEvent.SomethingsChanged += (what) => Console.WriteLine (what);

			//Trigger the event
			theEvent.changeSomething ("Hello World");
		}
	}
}

