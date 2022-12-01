using System;

public static class Globals
{
	internal static  void Main()
	{
		int n;
		int f1;
		int f2;
		int f3;
		n = Convert.ToInt32(Console.ReadLine());
		f1 = 0;
		f2 = 1;

		for (int i = 3; i <= n; i++)
		{
			f3 = f1 + f2;
			f1 = f2;
			f2 = f3;
		}
		if (n == 1)
		{
			Console.Write(0);
		}
		else
		{
			if (n == 2)
			{
				Console.Write(1);
			}
			else
			{
				Console.Write(f3);
			}
		}
		
	}
}
