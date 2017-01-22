using System;

namespace FunctionalCalculator
{
	class MainClass
	{
		public static int evaluate(string expression)
		{
			return 0;
		}
		public static void Main(string[] args)
		{
			string foo = "";
			while (foo != "quit" && foo != "end")
			{
				foo = Console.ReadLine();
				Console.WriteLine(evaluate(foo));
			}
		}
	}
}
