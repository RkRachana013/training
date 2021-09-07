using System;

namespace Assignment2
{
	class firstA
	{
		public static int sumOfPrimes(int from, int to)
		{
			int i, p, k, s = 0;
			{

				for (i = 1; i <= 10; i++)
				{
					k = 2;
					p = 1;
					while (k < i)
					{
						if (i % k == 0)
						{
							p = 0;
							break;
						}
						k++;
					}
					if (p == 1)
					{
						s = s + i;
					}
				}

				return(s);
			}
		}
		public static void Main(string[] args)
		{

			var from = MyConsole.GetNumber("Enter the First value");
			var to = MyConsole.GetNumber("Enter the Second value");
			int addedValue = sumOfPrimes(from, to);
			Console.WriteLine($"The Added value: {addedValue}");
			Console.Read();

		}
	}
}
