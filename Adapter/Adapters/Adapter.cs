using Adapter.Implementations;

namespace Adapter.Adapters
{
	internal static class Adapter
	{
		public static void Sort(this int[] array)
		{
			var bubbleSort = new BubbleSortForInt();
			bubbleSort.BubbleSort(array);
		}
	}
}
