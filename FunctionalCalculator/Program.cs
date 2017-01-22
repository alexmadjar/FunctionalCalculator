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
			while (true)
			{
				foo = Console.ReadLine();
				if (foo == "quit" || foo == "end")
				{
					break;
				}
				Console.WriteLine(evaluate(foo));
			}
		}
	}
}
