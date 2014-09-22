using System;

namespace CompletionCB
{
	
	public class TestApp
	{
	
		public static void Main(string[] args)
		{
			FileReaderApp myApp = new FileReaderApp();
			myApp.actionRequiringFile(@"..\..\test.xml");
			myApp.actionRequiringFile("FileAsync.exe");
            myApp.actionRequiring2Files(@"..\..\test.xml", "FileAsync.exe");
			System.Console.ReadLine();

		}
	}
}
