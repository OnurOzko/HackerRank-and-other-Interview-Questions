using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StupidHackerRankQuestions
{
    internal class HRLonelyInteger
    {

        public int LonelyBoys(List<int> a)
        {
           //int[] lonerLads;
            //for (int i = 0; i < (a.Count - 1); i++)
            //{
            //    for (int z = (i + 1); z < (a.count - 2); z++)
            //    {

            //    }

            //}
            int res = a[0];
            for (int i = 1; i < a.Count; i++)
                res = res ^ a[i];

            return res;

        }
    }
}
