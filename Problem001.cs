using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			int ans = 233168;
			int max = 1000;

			int totalSum = 0;
			int TotalSeq = 3;

			List<int> sequence = new List<int>() { 2, 1, 3, 1, 2, 3, 3 };

			for (int i = 1; i < max; i++)
			{
				if (i % 3 == 0 || i % 5 == 0)
				{
					totalSum += i;
				}
			}

			int sum = 3;
			int index = 0;
			while ( sum < 999)
			{
				index = index % 7;
				TotalSeq += sum += sequence[index++];
			}


			Console.WriteLine(totalSum);
			Console.WriteLine(TotalSeq);
			Console.Read();
		}
	}
}
