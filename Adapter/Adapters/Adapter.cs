using Adapter.Implementations;

namespace Adapter.Adapters
{
	internal static class Adapter<T> where T : struct, IComparable<T>
	{
		public static void BubbleSort(T[] array)
		{
			var bubbleSort = new BubbleSortForNumbers<T>();
			bubbleSort.BubbleSort(array);
		}
	}
}
