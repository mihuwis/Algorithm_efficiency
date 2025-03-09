using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmEfficiency
{
    public class QuickSort
    {
        private int[] array;

        public QuickSort(int[] inputArray)
        {
            this.array = inputArray;
        }

        private int Partition(int low, int high)
        {
            int pivot = array[high]; // Wybieramy ostatni element jako pivot
            int i = low - 1; // Indeks dla mniejszego elementu

            for (int j = low; j < high; j++)
            {
                if (array[j] < pivot) // Jeśli element jest mniejszy od pivota, zamieniamy miejscami
                {
                    i++;
                    Swap(i, j);
                }
            }

            Swap(i + 1, high); // Przesuwamy pivot na właściwe miejsce
            return i + 1;
        }

        // Rekurencyjna funkcja QuickSort
        public void SortArray(int low, int high)
        {
            if (low < high)
            {
                int pivotIndex = Partition(low, high); // Znajdujemy miejsce podziału

                SortArray(low, pivotIndex - 1); // Sortujemy lewą część
                SortArray(pivotIndex + 1, high); // Sortujemy prawą część
            }
        }

        // Metoda pomocnicza do zamiany elementów
        private void Swap(int i, int j)
        {
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
    }
}
