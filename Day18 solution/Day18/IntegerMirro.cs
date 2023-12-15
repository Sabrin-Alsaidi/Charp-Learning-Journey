using System;
namespace Day18
{
	public static class IntegerMirro
	{
		public static int Mirro(this int num)
		{
			int reminder, result = 0;
			while (num != 0)
			{
				reminder = num % 10;
				result = result * 10 + reminder;
				num = num/10;
			}
				return result;

		}
	}
}

