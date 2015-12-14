using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Net;
using System.IO;
using System.Collections;
using downloadthread;
namespace downn
{
	public class down
	{
		private static readonly object obj = new object();
		static string filee;
		//下载
		public int downn(string str , int i)
		{
			lock (obj) 
			{
				int id = Thread.CurrentThread.ManagedThreadId; 
				
				WebClient MyWebClient = new WebClient ();
				MyWebClient.Credentials = CredentialCache.DefaultCredentials;
				Byte[] pageData = MyWebClient.DownloadData (str);
				string pageHtml = Encoding.Default.GetString (pageData);   
				Console.WriteLine("address?");
				filee = Console.ReadLine ();
				FileStream aFile = new FileStream(filee, FileMode.Open);
				StreamWriter write = new StreamWriter (aFile);
				write.WriteLine(pageHtml);
				write.Close();
				
				
				int id1 = Thread.CurrentThread.ManagedThreadId; 
				
				int id2= Thread.CurrentThread.ManagedThreadId; 
				
				
				Thread current = Thread.CurrentThread;
				
				this.goo ();
				
				
				return 1;
			}
		}
		
		public void goo ()
		{
			int id = Thread.CurrentThread.ManagedThreadId; 	
			thread thr = new thread();
			thr.down2();
		}
		
		
		
		
		
		
		
		
		
		
	}
}
