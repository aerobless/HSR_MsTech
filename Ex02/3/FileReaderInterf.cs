using System;
using System.IO;

namespace CompletionCB
{
    /*
	interface IFileReaderClient //callback interface
	{
		void ReadCompleted(String filename, byte[] data); 
		void ReadFailed(String filename, IOException ex);
	}*/
   public delegate void ReadCompleted(String filename, byte[] data);
   public delegate void ReadFailed(String filename, IOException ex);

	class AFileReader 
	{
		private class AsyncReader 
		{
			private string fileName = null;
            private ReadCompleted readCompleted = null;
            private ReadFailed readFailed = null;

			/*private IFileReaderClient fileReaderClient = null;*/

			public AsyncReader(String fn,  ReadCompleted c, ReadFailed f) 
			{
                fileName = fn; readCompleted = c; readFailed = f;
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
                    if (readCompleted != null)
                        readCompleted(fileName, buffer);
				}
				catch (IOException ex) 
				{
                    if (readFailed != null)
                        readFailed(fileName, ex);
				}
			}
		}

		public void ReadAsync(String filename,  ReadCompleted rc, ReadFailed rf/*callback*/)
		{ 
			//AsyncReader-Objekt mit korrekten Parametern erzeugen
			AsyncReader myReader = new AsyncReader(filename, rc, rf);
			//Worker-Thread starten, welcher doRead ausführt
			new System.Threading.Thread(new System.Threading.ThreadStart(myReader.doRead)).Start();
		}
	}
}




	
