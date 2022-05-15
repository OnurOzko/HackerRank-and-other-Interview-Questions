using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    /// <summary>
    /// Going to make it possible to run every example from here later on.
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            int menuOption = 0;
            int menuInt = 0;
            bool correctInput = false;
            string menuString;

            while (true)
            {
                Console.WriteLine("Welcome to my Repo for the Questions I have solved.\nPlease enter a number from my list to try out the method I have created.\nTo see the list, press 0");
                menuOption = Int32.Parse(Console.ReadLine());
                switch (menuOption)
                {
                    case 0:
                        Console.WriteLine("List: 0\nCaesers Chiper: 1\nCounting Sort: 2\nDiagonal Differences: 3\nFind Median: 4\nFind Missing Int: 5\nGrid Challenge: 6\n");
                        break;

                    case 1:
                        Console.WriteLine("Enter a string to cipher.(Ints wont get converted due to nature of question but I can do it later too)");
                        menuString = Console.ReadLine();
                        Console.WriteLine("Enter a number to encrpyt the string with.");
                        menuInt = Int32.Parse(Console.ReadLine());
                        menuString = HRCaesarsChiper.caesarCipher(menuString,menuInt);
                        Console.WriteLine("Encrypted string: " + menuString);
                        break;

                    case 2:
                        Console.WriteLine("Please enter the length of a list you want to work with. It must be with in 0 to Int32");
                        menuInt = Int32.Parse(Console.ReadLine());
                        for(int i = 0; i < menuInt; i++)
                        {
                            while(correctInput == false)
                            {
                                Console.WriteLine("Please enter a number");
                                correctInput = int.TryParse(Console.ReadLine(), out menuInt);

                                if (!correctInput)
                                {
                                    Console.Write("Your input was not a number.");
                                }
                            }

                        }
                        break;


                }
            }

            //            Console.WriteLine("bruh");
            //            int n = Convert.ToInt32(Console.ReadLine().Trim());

            //            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            //            HRPlusMinus.plusMinus(arr);


            //            List<int> brh = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            //            HRMinMaxSum.miniMaxSum(brh);

            //            var elements = new Dictionary<string, string>();  

            ////------------------------------------------ FOR MATRIX GAME----------------------------------------//
            //            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            //            int q = Convert.ToInt32(Console.ReadLine().Trim());

            //            for (int qItr = 0; qItr < q; qItr++)
            //            {
            //                int bruh = Convert.ToInt32(Console.ReadLine().Trim());

            //                List<List<int>> matrix = new List<List<int>>();

            //                for (int i = 0; i < 2 * bruh; i++)
            //                {
            //                    matrix.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(matrixTemp => Convert.ToInt32(matrixTemp)).ToList());
            //                }

            //                int result = HRMatrixGame.flippingMatrix(matrix);

            //                textWriter.WriteLine(result);
            //            }

            //            textWriter.Flush();
            //            textWriter.Close();
        }
    }
}





