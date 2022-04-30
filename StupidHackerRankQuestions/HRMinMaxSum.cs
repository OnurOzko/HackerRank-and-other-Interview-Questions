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

namespace StupidHackerRankQuestions
{


    class HRMinMaxSum
    {



        /*
         * Complete the 'miniMaxSum' function below.
         *
         * The function accepts INTEGER_ARRAY arr as parameter.
         */




        /*
         * Complete the 'miniMaxSum' function below.
         *
         * The function accepts INTEGER_ARRAY arr as parameter.
         */

        public static void miniMaxSum(List<int> arr)
        {
            ulong[] myArray;
            int arrayLengthio;
            List<ulong> arrLong = arr.ConvertAll(i => (ulong)i);
            myArray = arrLong.ToArray();
            arrayLengthio = myArray.Length;

            ulong smallestNumber = myArray[0];
            ulong biggestNumber = myArray[0];
            ulong total = 0;

            for (int i = 0; i < arrayLengthio; i++)
            {
                if (smallestNumber > myArray[i])
                {
                    smallestNumber = myArray[i];
                }
                if (biggestNumber < myArray[i])
                {
                    biggestNumber = myArray[i];
                }

            }

            for (int z = 0; z < arrayLengthio; z++)
            {
                total = total + myArray[z];
            }

            Console.WriteLine((total - biggestNumber) + " " + (total - smallestNumber));


        }

    }
}



//Given five positive integers, find the minimum and maximum values that can be calculated by summing exactly four of the five integers. Then print the respective minimum and maximum values as a single line of two space-separated long integers.

//Example
//The minimum sum is and the maximum sum is

//. The function prints

//16 24

//Function Description

//Complete the miniMaxSum function in the editor below.

//miniMaxSum has the following parameter(s):

//    arr: an array of

//    integers

//Print

//Print two space-separated integers on one line: the minimum sum and the maximum sum of
//of

//elements.

//Input Format

//A single line of five space-separated integers.

//Constraints

//Output Format

//Print two space-separated long integers denoting the respective minimum and maximum values that can be calculated by summing exactly four of the five integers. (The output can be greater than a 32 bit integer.)

//Sample Input

//1 2 3 4 5

//Sample Output

//10 14

//Explanation

//The numbers are
//, , , , and

//. Calculate the following sums using four of the five integers:

//    Sum everything except 

//, the sum is
//.
//Sum everything except
//, the sum is
//.
//Sum everything except
//, the sum is
//.
//Sum everything except
//, the sum is
//.
//Sum everything except
//, the sum is

//    .

//Hints: Beware of integer overflow! Use 64-bit Integer.
