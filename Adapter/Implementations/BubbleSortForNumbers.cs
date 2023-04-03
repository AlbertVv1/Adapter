using Adapter.Interfaces;

namespace Adapter.Implementations
{
	internal class BubbleSortForNumbers<T> : IBubbleSort<T> where T : struct, IComparable<T>
	{
		public void Swap(ref T firstArgument, ref T secondArgument)
		{
			var temp = firstArgument;
			firstArgument = secondArgument;
			secondArgument = temp;
		}

		public void BubbleSort(T[] array)
		{
			for (int i = 0; i < array.Length; i++)
			{
				for (int j = 0; j < array.Length - 1 - i; j++)
				{
					if (array[j].CompareTo(array[j + 1]) > 0)
					{
						Swap(ref array[j], ref array[j + 1]);
					}
				}
			}
		}
	}
}
