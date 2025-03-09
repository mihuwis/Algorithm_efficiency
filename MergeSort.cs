using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmEfficiency
{
    public class MergeSort
    {
        private int[] array;

        public MergeSort(int[] inputArray)
        {
            this.array = inputArray;
        }

        private void Merge(int left, int middle, int right)
        {
            int leftSize = middle - left + 1;
            int rightSize = right - middle;

            int[] leftArray = new int[leftSize];
            int[] rightArray = new int[rightSize];

            for (int i = 0; i < leftSize; i++)
                leftArray[i] = array[left + i];
            for (int j = 0; j < rightSize; j++)
                rightArray[j] = array[middle + 1 + j];

            int leftIndex = 0, rightIndex = 0, mergedIndex = left;

            while (leftIndex < leftSize && rightIndex < rightSize)
            {
                if (leftArray[leftIndex] <= rightArray[rightIndex])
                {
                    array[mergedIndex] = leftArray[leftIndex];
                    leftIndex++;
                }
                else
                {
                    array[mergedIndex] = rightArray[rightIndex];
                    rightIndex++;
                }
                mergedIndex++;
            }

            while (leftIndex < leftSize)
            {
                array[mergedIndex] = leftArray[leftIndex];
                leftIndex++;
                mergedIndex++;
            }

            while (rightIndex < rightSize)
            {
                array[mergedIndex] = rightArray[rightIndex];
                rightIndex++;
                mergedIndex++;
            }
        }

        public void SortArray(int left, int right)
        {
            if (left < right)
            {
                int middle = left + (right - left) / 2;

                SortArray(left, middle);
                SortArray(middle + 1, right);
                Merge(left, middle, right);
            }
        }

    }
}
