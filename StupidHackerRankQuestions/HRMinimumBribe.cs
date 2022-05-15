using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

namespace AlgorihmQuestions
{

    class HRMinimumBribe
    {

        /*
         * Complete the 'minimumBribes' function below.
         *
         * The function accepts INTEGER_ARRAY q as parameter.
         */

        public static void minimumBribes(List<int> q)
        {
            int count = 0;
            int secondToMin = int.MaxValue;
            int min = int.MaxValue;
            for (int i = q.Count - 1; i >= 0; i--)
            {
                if (q[i] - i > 3)
                {
                    Console.WriteLine("Too chaotic");
                    return;
                }
                if (q[i] > secondToMin) count += 2;
                else if (q[i] > min) count += 1;
                if (q[i] < min)
                {
                    secondToMin = min;
                    min = q[i];
                }
                else if (q[i] < secondToMin) secondToMin = q[i];
            }
            Console.WriteLine(count);
        }

        //class Solution
        //{
        //    public static void Main(string[] args)
        //    {
        //        int t = Convert.ToInt32(Console.ReadLine().Trim());
        //        for (int tItr = 0; tItr < t; tItr++)
        //        {
        //            int n = Convert.ToInt32(Console.ReadLine().Trim()); // unnecessary but needed
        //            List<int> q = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(qTemp => Convert.ToInt32(qTemp)).ToList();
        //            HRMinimumBribe.minimumBribes(q);
        //        }
        //    }
        //}
    }
}
