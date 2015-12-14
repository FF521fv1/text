using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using Openfile;
using System.Collections;
using downn;
namespace downloadthread
{
	public class thread
	{
		private static readonly object obj = new object();
		down load = new down ();
		ArrayList arr = new ArrayList ();
		private static ArrayList arr2 = new ArrayList ();
		string[] str = new string[10];
		public Thread[] downloadthread ;
		Thread mmian ;
		int i = 0 ;
		int count = 0 ;
		int g = 0 ;
		int k = 0 ;
		openfile ope ;
		string filee;
		
		public void threadd()
		{
			
			openfile ope = new openfile ();
			openfile _ope = new openfile ();
			arr = ope._openfile ();
			int count = 0;
			downloadthread = new Thread[4];
			
			foreach (string str in arr)
				arr2.Add (str);
			this.creat ();
		}
		//创建线程
		public void creat()
		{
			foreach (string str in arr)
				arr2.Add (str);
			
			
			for (int delet = 0; delet <=3; delet++) 
			{
				arr2.RemoveAt(0);
				
			}
			
			for( ; i <= 3 ; i++)
			{
				Thread.Sleep(1000);
				
				downloadthread[i] = new Thread(dow);
				downloadthread[i].Start();
				
				count ++ ;
			}
			
		}
		
		
		
		public void dow()
		{
			lock(obj)
			{
				
				string strr = Convert.ToString(arr [0]);
				Console.WriteLine("!!!!!!!!!!!!!!!!!!!!!!!!!!this{0} ",arr[0]);
				arr.RemoveAt (0);
				
				if(arr[0] == null)
				{
					Console.WriteLine("nununununununununununu");
					
				}
				
				g = load.downn (strr, i);
			}
			
			
		}
		public void down2()
		{
			lock (obj)
			{
				arr2.RemoveAt(0);
				string strr = Convert.ToString(arr2 [0]);
				Console.WriteLine ("arr2arr2arr2{0}", strr);
				load.downn (strr, i);
				
			}
			
		}
		
		
		
	}
}
