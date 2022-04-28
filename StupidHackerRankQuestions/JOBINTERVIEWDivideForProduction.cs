using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StupidHackerRankQuestions
{
    internal class JOBINTERVIEWDivideForProduction
    {

        // you can also use other imports, for example:
        // using System.Collections.Generic;

        // you can write to stdout for debugging purposes, e.g.
        // Console.WriteLine("this is a debug message");

        public int solution(string S)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            //
            int length = S.Length; //no need to convert to long or ulong due to our N
            int lNumber = 0;
            int rNumber = 0;
            int divideNumber = 0;

            for (int i = 0; i < length; i++)
            {
                if (S.Substring(i, 1) == "L")
                {
                    lNumber++;
                }
                else if (S.Substring(i, 1) == "R")
                {
                    rNumber++;
                }

                if (lNumber == rNumber && lNumber != 0 && rNumber != 0)
                {
                    divideNumber++;
                    lNumber = 0;
                    rNumber = 0;
                }
            }

            return divideNumber;
        }


    }
}

