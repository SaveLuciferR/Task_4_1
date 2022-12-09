using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace Task_4_1
{
	class Programm
	{
		static double res(double x, int n)
		{
			double result;

			if (n == 0) result = 1;
			else if (n < 0) result = 1 / res(x, Math.Abs(n));
			else result = x * res(x, n - 1);

			return result;
		}

		static void Main(string[] agrs)
		{
			try
			{
				double x;

				while (true)
				{
					Console.Write("Введите x: ");
					x = Convert.ToDouble(Console.ReadLine());

					if (x != 0)
					{
						break;
					}
					Console.WriteLine("X не может быть равен 0");
				}

				Console.Write("Введите n: ");
				int n = Convert.ToInt32(Console.ReadLine());

				Console.WriteLine("Число {0} в степени {1} = {2}", x, n, res(x, n));
			}
			catch
			{
				Console.WriteLine("Введите корректные значения");
			}


		}
	}
}