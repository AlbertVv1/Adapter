namespace Adapter.Interfaces
{
	internal interface IBubbleSortForInt<T>
	{
		public void BubbleSort(T[] array);

		public void Swap(ref T firstArgument, ref T secondArgument);
	}
}
