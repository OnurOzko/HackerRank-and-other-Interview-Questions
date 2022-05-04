using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StupidHackerRankQuestions
{
    internal class HRWeirdBracketQuestion
    {

        /*
         * Complete the 'isBalanced' function below.
         *
         * The function is expected to return a STRING.
         * The function accepts STRING s as parameter.
         */

        public static string isBalanced(string s)
        {
            if (s.Length == 1 || s.Length % 2 != 0)
            {
                return "NO";
            }
            while (!s.Equals(s.Replace("[]", "")) || !s.Equals(s.Replace("()", "")) || !s.Equals(s.Replace("{}", "")))
            {
                s = s.Replace("[]", "");
                s = s.Replace("()", "");
                s = s.Replace("{}", "");
            }

            if (s.Length == 0)
            {
                return "YES";
            }
            else
            {
                return "NO";
            }

            //had to rewrite it because how poorly hackerrack explains some of the rules... I swear this page sometimes..
            //     int strLength = s.Length;
            //     int strHalf = ((strLength - 1) / 2) + 1;
            //     int operationStatus = 0;
            //     int halfWay = strLength / 2;
            //     char[] startSymbol = {'{', '[', '('};
            //     char[] endSymbol = {'}', ']', ')'};
            //     char[] charS = s.ToCharArray();


            //     if(strLength % 2 == 1){
            //         for(int z = 0; z < startSymbol.Length; z++){
            //             if(charS[strLength - 1] == startSymbol[z]){
            //                 Console.WriteLine("z: " + z );
            //                 return "NO";
            //             }
            //         }
            //     }

            //     for(int z = 0; z < strHalf; z++){
            //         if(!Char.IsLetterOrDigit(charS[z])){
            //             for(int p = 0; p < startSymbol.Length; p++){
            //                 if(charS[z] == startSymbol[p]){
            //                     if(endSymbol[p] != charS[strLength - (1 + z)]){
            //                         Console.WriteLine("z: " + z + " first one: " + charS[z] + " second one: " + charS[strLength - (1 + z)]);
            //                         return "NO";
            //                     }
            //                 }
            //             } 
            //         }
            //     }

            //     return "YES";
        }
    }
}




//Question

//A bracket is considered to be any one of the following characters: (, ), {, }, [, or].

//Two brackets are considered to be a matched pair if the an opening bracket (i.e., (, [, or {) occurs to the left of a closing bracket(i.e., ), ], or }) of the exact same type. There are three types of matched pairs of brackets: [], { }, and().

//A matching pair of brackets is not balanced if the set of brackets it encloses are not matched. For example, {[(])} is not balanced because the contents in between { and } are not balanced. The pair of square brackets encloses a single, unbalanced opening bracket, (, and the pair of parentheses encloses a single, unbalanced closing square bracket, ].

//By this logic, we say a sequence of brackets is balanced if the following conditions are met:

//    It contains no unmatched brackets.
//    The subset of brackets enclosed within the confines of a matched pair of brackets is also a matched pair of brackets.

//Given

//strings of brackets, determine whether each sequence of brackets is balanced. If a string is balanced, return YES. Otherwise, return NO.

//Function Description

//Complete the function isBalanced in the editor below.

//isBalanced has the following parameter(s):

//    string s: a string of brackets

//Returns

//    string: either YES or NO

//Input Format

//The first line contains a single integer
//, the number of strings.
//Each of the next lines contains a single string

//, a sequence of brackets.

//Constraints

//, where

//    is the length of the sequence.
//    All chracters in the sequences ∈ { {, }, (, ), [,] }.

//Output Format

//For each string, return YES or NO.

//Sample Input

//STDIN Function ----- -------- 3 n = 3 {[()]} first s = '{[()]}' {[(])} second s = '{[(])}' {{[[(())]]}} third s = '{{[[(())]]}}'

//Sample Output

//YES
//NO
//YES

//Explanation

//    The string {[()]} meets both criteria for being a balanced string.
//    The string {[(])} is not balanced because the brackets enclosed by the matched pair { and } are not balanced: [(]).
//    The string
//{ { [[(())]]} }
//meets both criteria for being a balanced string.
