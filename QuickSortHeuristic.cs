using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmEfficiency
{
    public class QuickSortHeuristic
    {
        private int[] array;

        public QuickSortHeuristic(int[] inputArray)
        {
            this.array = inputArray;
        }
        public void SortArray()
        {
            Array.Sort(array);
        }
    }
}
