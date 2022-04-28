using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StupidHackerRankQuestions
{
    internal class HRPalindrome
    {
        static int palindromeIndex(string s)
        {
            int maxIndex = s.Length / 2;

            for (int i = 0; i < maxIndex; i++)
            {
                if (s[i] != s[s.Length - 1 - i])
                {
                    if (s.Substring(i + 1, 2) == Reverse(s.Substring((s.Length - 1 - i) - 1, 2)))
                    {
                        return i;
                    }
                    else
                    {
                        return (s.Length - 1 - i);
                    }
                }
            }

            return -1;
        }

        static string Reverse(string str)
        {
            string reverse = "";
            int Length = 0;
            Length = str.Length - 1;
            while (Length >= 0)
            {
                reverse = reverse + str[Length];
                Length--;
            }
            return reverse;
        }

    }
}