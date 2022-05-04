using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorihmQuestions
{
    internal class HRDiagonalDifferences
    {
        public int diagonalSub(List<List<int>> arr)
        {
            int diagonal1 = 0;
            int diagonal2 = 0;
            int length = arr.Count;

            for (int i = 0; i < length; i++)
            {
                diagonal1 = arr[i][i] + diagonal1;
                diagonal2 = arr[length - i - 1][i] + diagonal2;
            }

            int total = System.Math.Abs(diagonal1 - diagonal2);

            return total;

        }
    }
}
