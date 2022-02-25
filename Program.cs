using System;

namespace assignment
{
	class Program
	{
		public static void Main(string[] args)
		{
			int i= 12;
			double d=4.0;
			string s= "is the best place to learn and practice coding!";
			
			Console.WriteLine("Enter the second integer");
			int i2=Convert.ToInt32(Console.ReadLine());
			
			Console.WriteLine("Enter The second double");
			double d2 = Convert.ToDouble(Console.ReadLine());
			
			Console.WriteLine("Enter The second String");
			string s2 = Console.ReadLine();
			
			i=i+i2;
			d=d+d2;
//			s=s2 + " " +s;
			
			Console.WriteLine(i);
			Console.WriteLine(d);
			Console.WriteLine("{0}",s2 + " " + s);
			Console.Read();
			
		}
	}
}