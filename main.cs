using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using downloadthread;
namespace main
{
	class Program
	{
		static void Main(string[]args)
		{
			try
			{
				
				Console.WriteLine("input");
				int i = Convert.ToInt32(Console.ReadLine());
				
				if(i == 1)
				{
					Console.WriteLine("ok.");
					thread thr = new thread();
					thr.threadd();
				}
				else
					Console.WriteLine("error");
				
			}
			
			catch (IOException ex)
			{
				Console.WriteLine(ex.Message);
				Console.ReadLine();
				return ;
			}
		}
	}
}
