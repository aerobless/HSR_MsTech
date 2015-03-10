using System;

namespace Something
{
	public class Classes
	{
		public Classes ()
		{
		}

		public void Run ()
		{
			//Parameterless Constructor
			Robot emptyRobot = new Robot ();
			emptyRobot.Identify ();

			//Parameterless Constructor with stuff
			Robot fullRobot = new Robot{ Name = "Hal9000", Age = 99 };
			fullRobot.Identify ();

			//Normal Constructor
			Robot normalRobot = new Robot ("iDroid");
			normalRobot.Identify ();

			//Mixed Constructor
			Robot mixedRobot = new Robot ("iRobot"){ Age = 3 };
			mixedRobot.Identify ();

			//Property Example
			PropertyExample propertyExample = new PropertyExample ();
			propertyExample.CurrentPrice = 10;
			Console.Out.WriteLine ("The current price is " + propertyExample.CurrentPrice + "CHF.");
			Console.Out.WriteLine ("In 10years the price will be " + propertyExample.FuturePrice + "CHF.");

			//Partial Class Example
			PartialTestClass partialExample = new PartialTestClass ();
			partialExample.MethodInPartial1 ();
			partialExample.methodInPartial2 ();

		}
	}

	public class Robot
	{
		public string Name;
		public int Age;

		public Robot ()
		{
		}

		public Robot (string Name)
		{
			this.Name = Name;
		}

		public void Identify ()
		{
			Console.Out.WriteLine ("Hello! I'm " + Name + " and I'm " + Age + " years old!");
		}
	}

	public class PropertyExample
	{
		//private backing field
		decimal currentPrice;

		//public access property
		public decimal CurrentPrice {
			get { return currentPrice; }
			set { currentPrice = value; }
		}

		//Read-only/calculated property
		public decimal FuturePrice {
			get { return currentPrice * 10; }
		}
	}

	public partial class PartialTestClass
	{
		private String textForMethod2 = "Text for method in partial 2";

		public void MethodInPartial1 ()
		{
			Console.Out.WriteLine ("Method in partial 1");
		}

		//Stub for partial method definied here
		//Important: must be void and is implicitly private
		partial void PartialMethodTest ();

	}
	//some other stuff or even other file here...
	public partial class PartialTestClass
	{
		public void methodInPartial2 ()
		{
			//Accessing a variable in the other partial
			Console.Out.WriteLine (textForMethod2);
			PartialMethodTest ();
		}

		partial void PartialMethodTest ()
		{
			Console.Out.WriteLine ("\"hello\" from partial method");
		}
	}
}

