using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorihmQuestions
{
    internal class HRJumpingontheClouds
    {
        public static int jumpingOnClouds(List<int> c)
        {
            int jumps = 0;

            int i = 0;

            while(i < c.Count)
            {
                if (i+2 < c.Count)
                {
                    if(c[i + 2] > 0)
                    {
                        i++;
                    }
                    else
                    {
                        i += 2;
                    }
                }
                else
                {
                    i++;
                }

                jumps++;
            }

            return jumps;

        }
    }
}
