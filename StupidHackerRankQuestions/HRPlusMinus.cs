using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.CodeDom.Compiler;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;


namespace AlgorihmQuestions
{


    class HRPlusMinus
    {

        /*
         * Complete the 'plusMinus' function below.
         *
         * The function accepts INTEGER_ARRAY arr as parameter.
         */

        public static void plusMinus(List<int> arr)
        {
            int arrayLength = arr.Count();
            // Console.WriteLine(arrayLength);
            double positive = 0;
            double negative = 0;
            double zero = 0;
            double positivePercentage = 0.000000;
            double negativePercentage = 0.000000;
            double zeroPercentage = 0.000000;
            int[] myArray;


            myArray = arr.ToArray();

            for (int i = 0; i < arrayLength; i++)
            {
                if (myArray[i] > 0)
                {
                    //Console.WriteLine("This is positive:" + myArray[i]);
                    positive++;
                }
                else if (myArray[i] == 0)
                {
                    //Console.WriteLine("This is zero:" + myArray[i]);
                    zero++;
                }
                else
                {
                    //Console.WriteLine("This is negative:" + myArray[i]);
                    negative++;
                }
            }

            positivePercentage = positive / arrayLength;
            negativePercentage = negative / arrayLength;
            zeroPercentage = zero / arrayLength;



            //Console.WriteLine(positivePercentage.ToString("#.######"));
            //Console.WriteLine(negativePercentage.ToString("#.######"));
            //Console.WriteLine(zeroPercentage.ToString("#.######"));

            Console.WriteLine(Math.Round(positivePercentage, 6));
            Console.WriteLine(Math.Round(negativePercentage, 6));
            Console.WriteLine(Math.Round(zeroPercentage, 6));
        }

        

    }

}



//Given an array of integers, calculate the ratios of its elements that are positive, negative, and zero. Print the decimal value of each fraction on a new line with

//places after the decimal.

//Note: This challenge introduces precision problems. The test cases are scaled to six decimal places, though answers with absolute error of up to

//are acceptable.

//Example
//There are elements, two positive, two negative and one zero. Their ratios are , and

//. Results are printed as:

//0.400000
//0.400000
//0.200000

//Function Description

//Complete the plusMinus function in the editor below.

//plusMinus has the following parameter(s):

//    int arr[n]: an array of integers

//Print
//Print the ratios of positive, negative and zero values in the array. Each value should be printed on a separate line with

//digits after the decimal. The function should not return a value.

//Input Format

//The first line contains an integer,
//, the size of the array.
//The second line contains space-separated integers that describe

//.

//Constraints


//Output Format

//Print the following
//lines, each to

//decimals:

//    proportion of positive values
//    proportion of negative values
//    proportion of zeros

//Sample Input

//STDIN           Function
//-----           --------
//6               arr[] size n = 6
//- 4 3 -9 0 4 1   arr = [-4, 3, -9, 0, 4, 1]

//Sample Output

//0.500000
//0.333333
//0.166667

//Explanation

//There are
//positive numbers, negative numbers, and zero in the array.
//The proportions of occurrence are positive: , negative: and zeros: . 