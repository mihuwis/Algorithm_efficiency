using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmEfficiency
{
    public class DataGenerator
    {

        private static Random random = new Random();

        // Losowe liczby (random)
        public static int[] GenerateRandomArray(int size, int min = 1, int max = 1000)
        {
            return Enumerable.Range(0, size).Select(_ => random.Next(min, max)).ToArray();
        }

        // Posortowana rosnąco (sorted)
        public static int[] GenerateSortedArray(int size)
        {
            return Enumerable.Range(0, size).ToArray();
        }

        // Posortowana malejąco (reversed)
        public static int[] GenerateReversedArray(int size)
        {
            return Enumerable.Range(0, size).Reverse().ToArray();
        }

        // Prawie posortowana (almost sorted)
        public static int[] GenerateAlmostSortedArray(int size, int swaps = 5)
        {
            int[] arr = GenerateSortedArray(size);
            for (int i = 0; i < swaps; i++)
            {
                int idx1 = random.Next(size);
                int idx2 = random.Next(size);
                (arr[idx1], arr[idx2]) = (arr[idx2], arr[idx1]);
            }
            return arr;
        }

        // Kilka unikalnych wartości (few unique)
        public static int[] GenerateFewUniqueArray(int size, int uniqueValues = 10)
        {
            return Enumerable.Range(0, size).Select(_ => random.Next(1, uniqueValues + 1)).ToArray();
        } 
    }
}
