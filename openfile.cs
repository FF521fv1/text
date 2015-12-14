using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Collections;
using downn;
namespace Openfile
{
	public class openfile
	{
		//打开文件
		public ArrayList _openfile()
		{
			int i = 0;
			ArrayList arr = new ArrayList{};
			string[] str = new string[10];;
			string strLine ;
			string url =  Console.ReadLine();
			FileStream aFile = new FileStream(url, FileMode.Open);
			StreamReader sr = new StreamReader(aFile);
			strLine = sr.ReadLine();
			while(strLine != null)
			{
				arr.Add(strLine);
				strLine = sr.ReadLine();
				i++;
			}
			sr.Close();
			return arr; 
		}
		
	}
	
}