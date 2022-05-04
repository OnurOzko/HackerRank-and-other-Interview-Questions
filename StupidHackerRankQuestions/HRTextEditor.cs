using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StupidHackerRankQuestions
{
    internal class HRTextEditor
    {
        static void Main(String[] args)
        { //10 / 15 (5 due to timeout)
            /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
            List<string> pastDeeds = new List<string>();
            int k = Int32.Parse(Console.ReadLine());
            string input;
            string output = "";
            string tempInput;
            string tempInput2;

            for (int i = 0; i < k; i++)
            {
                input = Console.ReadLine();
                tempInput = input.Split(' ')[0];

                switch (tempInput)
                {
                    case "1":
                        pastDeeds.Add(output);
                        tempInput2 = input.Split(' ')[1];
                        output = Appendo(output, tempInput2);
                        break;
                    case "2":
                        pastDeeds.Add(output);
                        tempInput2 = input.Split(' ')[1];
                        output = Deleto(output, Int32.Parse(tempInput2));
                        break;
                    case "3":
                        tempInput2 = input.Split(' ')[1];
                        Printo(output, Int32.Parse(tempInput2));
                        break;
                    case "4":
                        output = pastDeeds[pastDeeds.Count - 1];
                        pastDeeds.RemoveAt(pastDeeds.Count - 1);
                        break;
                }
            }
        }


        public static string Appendo(string s, string w)
        {
            s = s + w;
            return s;
        }
        public static string Deleto(string s, int k)
        {
            s = s.Substring(0, (s.Length - k));
            return s;
        }

        public static void Printo(string s, int k)
        {
            if (s.Length == 1)
            {
                Console.WriteLine(s);
            }
            else if (s.Length > 0)
            {
                char c = s[k - 1];
                Console.WriteLine(c);
            }
            else
            {
                Console.WriteLine();
            }
        }
    }
}

//Implement a simple text editor. The editor initially contains an empty string, . Perform operations of the following

//types:

//    append

//- Append string to the end of
//.
//delete
//- Delete the last characters of
//.
//print
//- Print the character of
//.
//undo
//- Undo the last (not previously undone) operation of type or , reverting

//    to the state it was in prior to that operation.

//Example


//operation
//index   S       ops[index]  explanation
//-----   ------  ----------  -----------
//0       abcde   1 fg        append fg
//1       abcdefg 3 6         print the 6th letter - f
//2       abcdefg 2 5         delete the last 5 letters
//3       ab      4           undo the last operation, index 2
//4       abcdefg 3 7         print the 7th characgter - g
//5       abcdefg 4           undo the last operation, index 0
//6       abcde   3 4         print the 4th character - d

//The results should be printed as:

//f
//g
//d