using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StupidHackerRankQuestions
{
    internal class HRPairs
    {
        public static int pairs(int k, List<int> arr)
        {
            int arrLength = arr.Count;
            int[] realArr = arr.ToArray();
            Array.Sort(realArr);
            int t = 0;
            int returnValue = 0;
            int m = 1;

            for (int z = 0; z < arrLength - 1; z++)
            {
                t = realArr[z + m] - realArr[z];
                if (t < k)
                {
                    for (m = 2; t < k && z + m < arrLength; m++)
                    {
                        t = realArr[z + m] - realArr[z];
                    }
                    m = 1;
                }
                if (t == k)
                {
                    returnValue++;
                }
            }

            return returnValue;


        }
    }


}
