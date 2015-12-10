using System;
using System.Linq;
using System.Collections.Generic;
class Program 
{
	public static void Main()
	{
		int number = 0;
		Console.WriteLine("input?");
		Console.WriteLine(" input ? one to four {0} " , number );
		number =Convert.ToInt32(Console.ReadLine());
		if(number == 1)
		{
			cat a = new cat();
			a.one();
		}
		if(number == 2)
		{
			fun mmm = new fun();
			func fff = new func();
			int n =  mmm.fun1();
			int _n = fff.fun2(n);
			fff.fun3(_n);
		}
		if(number == 3)
		{
			three thr = new three();
			thr._three();
		}
		if (number == 4)
		{
			four fff = new four();
			fff._four();
		}
		//cat a = new cat();
		//a.one();
		//		animal b ;
		//		b = a ;
		//		b.one();
	}
}
public class fun
{
	public int fun1()
	{
		int n = 0;
		for (int i = 100 ; i < 1000 ; i++)
		{
			if(i/7 == 3 && i/5 == 1)
			{
				n++;
			}
		}
		return n;
	}
}
public class func
{
	public virtual int fun2(int n)
	{
		int i = 0;
		if(n==2)
		{
			n = 1;
		}
		if(n==1)
		{
			n = 0;
		}
		for(i=2;i*i<=n;i++)
		{
			if(n%i==0)
			{
				n = 1 ;
			}
			else 
			{
				n = 0 ;
			}
		}
		return n ;
	}
	public virtual void fun3(int n)
	{
		if(n > 0)
		{
			Console.WriteLine("The end");
		}
		if(n == 0)
		{
			Console.WriteLine("Continue");
		}
	}
}
public class three
{

	public void _three()
	{
		int[] myint = new int[7];
		int m=0;
		int _int=0;  
		int n=0; 
		int max=0;
		int min=0;
		int temp=0;
		int  mmm=0;
		for(int i = 0 ; i < 7 ; i ++)
		{
			_int =Convert.ToInt32(Console.ReadLine());
			myint[i] = _int;			
			Console.WriteLine("this{0}",myint[i]);
		}
		max = myint[0];
		min = myint[0];		
		foreach(int str in myint)   
			Console.WriteLine("this{0}---------",str);
		for (int j = 0; j < myint.Length; j++)
		{
			if(myint[j]%2 == 0)
			{
				n++;
			}
			else
			{
				m++;
			}
		}
		Console.WriteLine("odd number is {0} Even numbers is {1}",m,n);
		//Console.WriteLine("max = {0} min = {0}",max,min);
		for(int k = 0 ; k < myint.Length ; k++)
		{
			if(myint[k]>max)
			{
				max = myint[k];
			}
			if(myint[k]<min)
			{
				min=myint[k];
			}
		}
		Console.WriteLine("max = {0} min = {1}",max,min);
mmm = max*min;
while(min!=0)
{
temp = max%min;
max = min;
min = temp;
}		
mmm = mmm/max;

char c = (char) mmm;
		Console.WriteLine("common multiple is {0}",mmm);
		Console.WriteLine("the ACSII is {0}",c);

	}
}
public class cat 
{
	public void one()
	{
		int[] myint = new int[7];
		int count = 0;
		int _int = 0;
		int max = 0;
		int min = 0;
		int linea = 0;
		int lineb = 0; 
		for(int i = 0 ; i < 7 ; i ++)
		{
			_int =Convert.ToInt32(Console.ReadLine());
			//myint[i] =Convert.ToInt32(_int);
			myint[i] = _int;			
			Console.WriteLine("this{0}",myint[i]);
		}
		for(int j = 0 ; j < myint.Length ; j++)
		{
			if(myint[j] > 0)
			{
				count ++;
				Console.WriteLine("more than 0 {0}"
						,myint[j]);
			}
		}
		max = myint[0];
		min= myint[0];
		for(int k = 1 ; k < myint.Length ; k++)
		{
			//Console.WriteLine("aaaaaaaaaaaaaaaaa");	
			if(myint[k]>max)
			{
				max = myint[k];
				linea = k;
			}
			if(myint[k]<min)
			{
				min = myint[k];
				lineb = k;
			}
			Console.WriteLine("max = {0}min = {1}linea = {2}lineb = {3}",max,min,linea,lineb);
		}		
		foreach(int str in myint)   
			Console.WriteLine("this{0}",str);

	}
}
public class four
{
	int[] myint = new int[5];
	int _int = 0 ;
	int n = 0 ;
	int j = 0 ;
	public void _four()
	{
		Console.WriteLine("five?");
		for (int i = 0; i < 5; i++) 
		{
			_int = Convert.ToInt32(Console.ReadLine());
			n += _int ;
			myint[i] = _int;			
			Console.WriteLine("this{0}",myint[i]);
		}
		while (n>0)
		{
			n=n/10;
				j++;
		}
		Console.WriteLine ("this is {0}", j);
		for (int i = 0 , g = myint.Length; i<myint.Length/2; i++ , g--)
		{
			int temp = 0 ;
			temp = myint[i];
			myint[i] = myint[g];
			myint[g] = temp ;
		}
		foreach(int str in myint)   
			Console.WriteLine("this!!!!!!{0}",str);
	}

}
