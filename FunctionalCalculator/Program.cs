using System;

namespace FunctionalCalculator
{
	class MainClass
	{
		public static int evaluate(string expression)
		{
			int val = 0;
			bool neg = expression[0] == '-';
			foreach (char c in expression)
			{
				if (c < '0' || c > '9')
				{
					continue;
				}
				val *= 10;
				val += c - '0';
			}
			if (neg)
			{
				val = -val;
			}
			return val;
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
