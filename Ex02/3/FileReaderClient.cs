using System;
using System.IO;

namespace CompletionCB
{

	//Testclient
	class FileReaderApp: IFileReaderClient 
	{ 
		protected AFileReader reader = new AFileReader();
		public void ReadCompleted(String filename, byte[] data) 
		{ 
			Console.WriteLine("readCompleted {0}  anz bytes: {1}",  filename, data.Length);
		}
		public void ReadFailed(String filename, IOException ex)
		{ 
			Console.WriteLine("readFailed {0}", filename);
			Console.WriteLine(ex);
		}
		public void actionRequiringFile(String filename) 
		{
			reader.ReadAsync(filename, this);
		}
		public void actionRequiring2Files(String filename1, String filename2) 
		{
			
			reader.ReadAsync(filename1, this);
			
			reader.ReadAsync(filename2, this);
			
			
		}
		public void actionNotRequiringFile() {  }
	}
	
	
}




	
