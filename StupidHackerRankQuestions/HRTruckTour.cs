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

namespace StupidHackerRankQuestions
{
    class HRTruckTour
    {

        /*
         * Complete the 'truckTour' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts 2D_INTEGER_ARRAY petrolpumps as parameter.
         */

        public static int truckTour(List<List<int>> petrolpumps)
        {

            long listLength = petrolpumps.LongCount();
            int start = 0;
            long total = 0;
            int dum = 0;
            int i = 0;
            int z = 0;
            int p = 0;


            if (listLength == 1)
            {
                return 0;
            }

            for (i = 0; i < listLength; i++)
            {
                start = 0;

                if ((petrolpumps[i][0] - petrolpumps[i][1]) < 1)
                {
                    dum++;
                    //Console.WriteLine("First Element : " + petrolpumps[i][0] + " Second Element: " + petrolpumps[i][1] + " dum count: " + dum);
                }
                else
                {
                    //Console.WriteLine("1th element: " + petrolpumps[z][0] + " 2th element:" + petrolpumps[z][1]);
                    //Console.WriteLine("whoops, returning!" + "total:" + total + " z:" + z + " debug :" + debug);
                    total = Convert.ToInt64(petrolpumps[i][0] - petrolpumps[i][1]);
                    //Console.WriteLine("first total: " + total);
                    for (p = 0, z = i; p < listLength && start == 0; z++)
                    {
                        if (z == listLength) { z = 0; }
                        if ((total + Convert.ToInt64(petrolpumps[z][0] - petrolpumps[z][1])) > 0)
                        {
                            p++;
                            total = total + Convert.ToInt64(petrolpumps[z][0] - petrolpumps[z][1]);
                            //Console.WriteLine("p: " + p + " total: " + total + " z: " + z);
                            //Console.WriteLine("1th element: " + petrolpumps[z][0] + " 2th element:" + petrolpumps[z][1]);
                        }
                        else
                        {
                            start = 1;
                            dum++;
                        }
                    } //end of second for
                    if ((p) == listLength)
                    {
                        return dum;
                    }
                }//end of main else
            }
            return 0; // end of first for
        } // end of method





        public static int truckTourAndWhereItWouldGo(List<List<int>> petrolpumps)
        {

            //I got the question wrong so I did another algorithm, thinking that, pick a spot where truck can start the min and find the last point where it stops
            //it works but it isn't the answer, sadly.
            int listLength = petrolpumps.Count;
            int i = 0;
            int start = 0;
            int total = 0;
            int z = 0;
            int debug = 0;

            for (i = 0; i < listLength && start == 0; i++)
            {
                if ((petrolpumps[i][0] - petrolpumps[i][1]) > -1)
                {
                    total = petrolpumps[i][0] - petrolpumps[i][1];

                    start = 1;
                }

            }

            // if (start == 0)
            // {
            //     return 0;
            // }

            for (z = i; total > 0; z++)
            {
                //Console.WriteLine("total:" + total + " z:" + z + " i:" + i + " listLength:" + listLength);
                if (z == listLength)
                {
                    z = 0;
                }

                //Console.WriteLine("total:" + total + " z:" + z);

                if (total + (petrolpumps[z][0] - petrolpumps[z][1]) < 0)
                {
                    debug = total + (petrolpumps[z][0] - petrolpumps[z][1]);
                    //Console.WriteLine("1th element: " + petrolpumps[z][0] + " 2th element:" + petrolpumps[z][1]);
                    //Console.WriteLine("whoops, returning!" + "total:" + total + " z:" + z + " debug :" + debug);
                    return z;
                }
                else
                {
                    total = total + (petrolpumps[z][0] - petrolpumps[z][1]);
                    petrolpumps[z][0] = 0;
                }
            }

            return z;

        }









    }




























        class bruh
         {
        public static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<List<int>> petrolpumps = new List<List<int>>();

            for (int i = 0; i < n; i++)
            {
                petrolpumps.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(petrolpumpsTemp => Convert.ToInt32(petrolpumpsTemp)).ToList());
            }

            int result = HRTruckTour.truckTour(petrolpumps);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }
    }
}



