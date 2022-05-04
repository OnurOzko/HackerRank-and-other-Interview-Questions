using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorihmQuestions
{
    internal class JISumOfEveryThree
    {
        //public int solution(int[] A)  sadly I couldn't finish this question in time
        //{
        //    int length = A.Length;
        //    //int[] brackets = new int[length]; there is no need for this solution as elements of A starts from 0
        //    //after C#  6.0(I think?) it automaticly inserts 0 value to every unassigned int of an int   array so there is no need for Array.Clear
        //    int biggestSum = 0;

        //    int[] Sums = new int[length]; //approx. we get one sum for each 3 numbers and +1 is for those 3 groups ending up prematurely, can be optimized

        //    for (int i = 0; i < length; i = i + 3)
        //    {  //can also be done with %
        //        if ((i + 3) <= (length - 1))
        //        {
        //            //brackets[i] = 1;
        //            A[i] = -9;
        //        }
        //    }

        //    for (int i = 0; i < length - 1; i++)
        //    {
        //        if (A[i] >= 0 && A[i + 1] >= 0)
        //        {
        //            Sums[i] = A[i] + A[i + 1];
        //        }
        //    }

        //    var sumDuplicates = Sums.GroupBy(x => x).Where(g => g.Count() > 1).Select(y => y.Key).ToList();



        //    return biggestSum;
        //}
    }
}
