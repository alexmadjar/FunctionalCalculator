﻿using System;
using System.Collections;

namespace FunctionalCalculator
{
	class MainClass
	{
		static int expectations = 0;

		public static int evaluate(string expression)
		{
			int val = 0;
			for (int i = 0; i < expression.Length; i++)
			{
				char c = expression[i];
				if (c == '-')
				{
					return val - evaluate(expression.Substring(i + 1));
				}
				if (c < '0' || c > '9')
				{
					continue;
				}
				val *= 10;
				val += c - '0';
			}
			return val;
		}

		public static int expectEqual(int exp, int act)
		{
			expectations++;
			if (exp != act)
			{
				Console.WriteLine("Test {0} Failed!", expectations);
				return 1;
			}
			return 0;
		}

		public static int runTests()
		{
			int failures = 0;
			failures += expectEqual(23, evaluate("23"));
			failures += expectEqual(-23, evaluate("-23"));
			failures += expectEqual(0, evaluate("junk"));
			failures += expectEqual(2, evaluate("9-7"));
			failures += expectEqual(-2, evaluate("7-9"));
			failures += expectEqual(8, evaluate("12-3-1"));
			return failures;
		}

		public static void Main(string[] args)
		{
			int failedTests = runTests();
			if (failedTests > 0)
			{
				Console.WriteLine("Failed {0}/{1} test(s)!", failedTests, expectations);
				return;
			}
			else
			{
				Console.WriteLine("All {0} tests passed!", expectations);
			}
			string input = "";
			while (true)
			{
				input = Console.ReadLine();
				if (input == "quit" || input == "end")
				{
					break;
				}
				Console.WriteLine(evaluate(input));
			}
		}
	}
}
