using System;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace AlgorithmEfficiency
{
    [SimpleJob]
    public class SortingBenchmark
    {
        private int[] arrInsertionSort;
        private int[] arrMergeSort;
        private int[] arrQuickSort;
        private int[] arrQuickSortHeuristic;

        [Params(10, 1000, 100000)] 
        public int ArraySize;

        [Params("random", "sorted", "reversed", "almost sorted", "few unique")] 
        public string DataType;

        [GlobalSetup] 
        public void Setup()
        {
            int[] baseArray = DataType switch
            {
                "random" => DataGenerator.GenerateRandomArray(ArraySize),
                "sorted" => DataGenerator.GenerateSortedArray(ArraySize),
                "reversed" => DataGenerator.GenerateReversedArray(ArraySize),
                "almost sorted" => DataGenerator.GenerateAlmostSortedArray(ArraySize),
                "few unique" => DataGenerator.GenerateFewUniqueArray(ArraySize),
                _ => throw new ArgumentException("Nieznany typ danych")
            };

            arrInsertionSort = (int[])baseArray.Clone(); // Tworzymy kopie tablicy dla każdego algorytmu
            arrMergeSort = (int[])baseArray.Clone();
            arrQuickSort = (int[])baseArray.Clone();
            arrQuickSortHeuristic = (int[])baseArray.Clone();
        }

        [Benchmark] 
        public void InsertionSortBenchmark()
        {
            InsertionSort insertionSort = new InsertionSort();
            insertionSort.SortArray(arrInsertionSort);
        }

        [Benchmark] 
        public void MergeSortBenchmark()
        {
            MergeSort mergeSort = new MergeSort(arrMergeSort);
            mergeSort.SortArray(0, arrMergeSort.Length - 1);
        }

        [Benchmark] 
        public void QuickSortBenchmark()
        {
            QuickSort quickSort = new QuickSort(arrQuickSort);
            quickSort.SortArray(0, arrQuickSort.Length - 1);
        }

        [Benchmark]
        public void QuickSortHeuristicBenchmark()
        {
            Array.Sort(arrQuickSortHeuristic);
        }
    }
}
