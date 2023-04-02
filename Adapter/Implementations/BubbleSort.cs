using Adapter.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Adapter.Implementations
{
	internal class BubbleSort : IBubbleSortForInt
	{
		public void Swap(ref int firstArgument, ref int secondArgument)
		{
			var temp = firstArgument;
			firstArgument = secondArgument;
			secondArgument = temp
		}

		public void BubbleSortt(int[] array)
		{
			for (int i = 0; i < array.Length; i++)
			{
				for (int j = 0; j < array.Length - 1 - i; j++)
				{
					if (array[j] > array[j + 1])
					{
						Swap(ref array[j], ref array[j + 1]);
					}
				}
			}
		}
	}
}
