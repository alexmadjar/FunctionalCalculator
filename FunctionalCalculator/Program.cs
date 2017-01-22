using System;

namespace FunctionalCalculator
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			string foo = "";
			while (foo != "quit" && foo != "end")
			{
				foo = Console.ReadLine();
				Console.WriteLine(foo);
			}
		}
	}
}
