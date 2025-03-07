using AlgorithmEfficiency;

InsertionSort insertionSort = new InsertionSort();

int[] arr = { 12, 11, 13, 5, 6 };

insertionSort.SortArray(arr);

foreach (int i in arr)
{
    Console.WriteLine(i);
}