using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorihmQuestions
{
    internal class HRPairingWıthHashSet
    {
        public static int sockMerchant(int n, List<int> ar)
        {

            var sockCount = 0;
            var set = new HashSet<int>();

            foreach (int i in ar)
            {
                if (!set.Contains(i))
                {
                    set.Add(i);
                }
                else
                {
                    sockCount++;
                    set.Remove(i);
                }
            }

            return sockCount;


            //int firstColor = 0;
            //int secondColor = 0;
            //int total = 0;

            //for (int i = 0; i < n; i++)
            //{

            //    if (ar[i] == 1)
            //        firstColor++;

            //    else if (ar[i] == 2)
            //        secondColor++;
            //}

            //firstColor = firstColor / 2;
            //secondColor = secondColor / 2;

            //total = firstColor + secondColor;

            //return firstColor;
        }
    }
}
