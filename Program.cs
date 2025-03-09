using AlgorithmEfficiency;


int[] arr01 = { 12, 11, 13, 5, 6, 22, 73, 3, 8, 7, 8, 8, 92, 773, 1, 0, 7, 21, 21 };
int[] arr02 = { 12, 11, 13, 5, 6, 22, 73, 3, 8, 7, 8, 8, 92, 773, 1, 0, 7, 21, 21 };
int[] arr03 = { 12, 11, 13, 5, 6, 22, 73, 3, 8, 7, 8, 8, 92, 773, 1, 0, 7, 21, 21 };


InsertionSort insertionSort = new InsertionSort();
MergeSort mergeSort = new MergeSort(arr02);
QuickSort quickSort = new QuickSort(arr03);

// Sortwoanie insertion sortem

insertionSort.SortArray(arr01);
Console.WriteLine("Insert join");
Console.WriteLine(string.Join(", ", arr01));

// sortowanie Merge sortem 

mergeSort.SortArray(0, arr02.Length -1);
Console.WriteLine("Merge join: ");
Console.WriteLine(string.Join(", ", arr02));

// Sortowanie Quick sortem 

quickSort.SortArray(0,arr03.Length -1);
Console.WriteLine("Sort quick");
Console.WriteLine(string.Join(", ", arr03));

