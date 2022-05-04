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
    internal class HRMatrixGame
    {




        /*
         * Complete the 'flippingMatrix' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts 2D_INTEGER_matrixAY matrix as parameter.
         */

        public static int flippingMatrix(List<List<int>> matrix)
        {
            int length = matrix.Count();
            int sum = 0;
            int n = length / 2;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    sum += Math.Max(Math.Max(matrix[i][j], matrix[i][length - j - 1]), Math.Max(matrix[length - i - 1][j], matrix[length - i - 1][length - j - 1]));
                }
            }
            return sum;


        }

    }
}






