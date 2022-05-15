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

class HRLegoBlocks //it is an extremely hard question and algorithm. I copied the solution but I need to check it again to understand.
{
    private const long Mod = 1000000007;
    private static long[] _tns = new long[1001]; // A000078 OEIS
    private static long[] _pws;
    private static long[] _sus;

    static HRLegoBlocks()
    {
        _tns[0] = 0;
        _tns[1] = 1;
        _tns[2] = 2;
        _tns[3] = 4;
        _tns[4] = 8;
    }

    public static int legoBlocks(int height, int width)
    {
        _pws = new long[1001];
        _sus = new long[1001];
        _sus[0] = 1;
        _sus[1] = 1;

        Tn(width);
        Pw(height, width);

        for (var i = 2; i <= width; i++)
        {
            var sum = 0L;
            for (var j = 1; j < i; j++)
                sum = (sum + ((_sus[j] * _pws[i - j]) % Mod)) % Mod;

            if (_pws[i] < sum) _pws[i] += Mod;
            _sus[i] = (_pws[i] - sum) % Mod;
        }

        return (int)_sus[width];
    }

    static void Tn(int width)
    {
        if (width < 5 || _tns[width] != 0) return;

        for (var i = 5; i <= width; i++)
            if (_tns[i] == 0)
                _tns[i] = ((
                    ((_tns[i - 1] + _tns[i - 2]) % Mod) +
                    ((_tns[i - 3] + _tns[i - 4]) % Mod)) % Mod);
    }

    static void Pw(int height, int width)
    {
        for (var i = 0; i <= width; i++)
        {
            var res = _tns[i];
            for (var j = 2; j <= height; j++)
                res = (res * _tns[i]) % Mod;

            _pws[i] = res;
        }
    }
}

//class Solution
//{
//    public static void Main(string[] args)
//    {
//        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

//        int t = Convert.ToInt32(Console.ReadLine().Trim());

//        for (int tItr = 0; tItr < t; tItr++)
//        {
//            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

//            int n = Convert.ToInt32(firstMultipleInput[0]);

//            int m = Convert.ToInt32(firstMultipleInput[1]);

//            int result = HRLegoBlocks.legoBlocks(n, m);

//            textWriter.WriteLine(result);
//        }

//        textWriter.Flush();
//        textWriter.Close();
//    }
//}






//You have an infinite number of 4 types of lego blocks of sizes given as (depth x height x width):

//d h	w
//1	1	1
//1	1	2
//1	1	3
//1	1	4

//Using these blocks, you want to make a wall of height
//and width

//. Features of the wall are:

//-The wall should not have any holes in it.
//- The wall you build should be one solid structure, so there should not be a straight vertical break across all rows of bricks.
//- The bricks must be laid horizontally.

//How many ways can the wall be built?

//Example


//The height is and the width is

//. Here are some configurations:

//image

//These are not all of the valid permutations. There are

//valid permutations in all.

//Function Description

//Complete the legoBlocks function in the editor below.

//legoBlocks has the following parameter(s):

//    int n: the height of the wall
//    int m: the width of the wall

//Returns
//- int: the number of valid wall formations modulo

//Input Format

//The first line contains the number of test cases

//.

//Each of the next
//lines contains two space-separated integers and

//.

//Constraints


//Sample Input

//STDIN   Function
//-----   --------
//4       t = 4
//2 2     n = 2, m = 2
//3 2     n = 3, m = 2
//2 3     n = 2, m = 3
//4 4     n = 4, m = 4

//Sample Output

//3  
//7  
//9  
//3375

//Explanation

//For the first case, we can have:

//image

//For the second case, each row of the wall can contain either two blocks of width 1, or one block of width 2. However, the wall where all rows contain two blocks of width 1 is not a solid one as it can be divided vertically. 