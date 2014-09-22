using System;
using System.IO;

namespace CompletionCB
{
	interface IFileReaderClient //callback interface
	{
		void ReadCompleted(String filename, byte[] data); 
		void ReadFailed(String filename, IOException ex);
	}

	class AFileReader 
	{
		private class AsyncReader 
		{
			private string fileName = null; 
			private IFileReaderClient fileReaderClient = null;

			public AsyncReader(String fn,  IFileReaderClient c) 
			{
				fileName = fn; fileReaderClient = c; 
			}

			public void doRead() 
			{ //wird in einem Worker-Thread gestartet
				byte[] buffer = new byte[1024]; // just for illustration 
				try 
				{
					FileStream s = new FileStream(fileName, 
						FileMode.Open, FileAccess.Read, FileShare.Read); 
					BinaryReader r = new BinaryReader(s);
					buffer = r.ReadBytes( buffer.Length );
					if (fileReaderClient != null) 
						fileReaderClient.ReadCompleted(fileName, buffer);
				}
				catch (IOException ex) 
				{
					if (fileReaderClient != null) 
						fileReaderClient.ReadFailed(fileName, ex);
				}
			}
		}

		public void ReadAsync(String filename, IFileReaderClient client /*callback*/)
		{ 
			//AsyncReader-Objekt mit korrekten Parametern erzeugen
			AsyncReader myReader = new AsyncReader(filename, client);
			//Woriker-Thread starten, welcher doRead ausführt
			new System.Threading.Thread(new System.Threading.ThreadStart(myReader.doRead)).Start();
		}

	}
	
}




	
