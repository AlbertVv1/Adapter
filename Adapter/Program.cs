using Adapter.Adapters;

var array = new int[5] { 7, 4, 2, 5, 6 };
Adapter<int>.BubbleSort(array);
foreach (var item in array)
{
	Console.WriteLine(item);
}