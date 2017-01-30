using System;

namespace DrawFilledSquare
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());

			PrintRow(n);
			for (int i = 0; i < n - 2; i++)
			{
				PrintMiddleRow(n);
			}
			PrintRow(n);
		}

		public static void PrintRow(int n)
		{
			Console.WriteLine(new string('-', 2 * n));
		}

		public static void PrintMiddleRow(int n)
		{
			Console.Write('-');
			for (int i = 1; i < n ; i++)
			{
				Console.Write("\\/");
			}
			Console.WriteLine('-');
		}
	}
}
