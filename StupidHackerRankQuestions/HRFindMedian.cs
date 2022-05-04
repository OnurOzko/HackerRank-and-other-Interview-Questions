using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorihmQuestions
{
    internal class HRFindMedian
    {
        public int Median(List<int> arr)
        {
            int length = arr.Count;
            int median = (length / 2);

            arr.Sort();

            median = arr[median];
            return median;
        }
    }
}
