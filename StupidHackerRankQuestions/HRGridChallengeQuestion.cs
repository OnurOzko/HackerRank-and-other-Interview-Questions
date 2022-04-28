using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StupidHackerRankQuestions
{
    internal class HRGridChallengeQuestion
    {
        public static string gridChallenge(List<string> grid)
        {
            for (int i = 0; i < grid.Count(); ++i)
            {
                char[] s = grid[i].ToCharArray(); //returns whole column with those row are equals to i
                Array.Sort(s);
                grid[i] = new string(s); //it is to insert a new string to the place of another string in an array, we used the char array to sort it then later to insert it
            }

            for (int i = 0; i < grid.Count() - 1; i++)
            {
                for (int j = 0; j < grid[i].Length; j++)
                {
                    if (grid[i][j] > grid[i + 1][j])
                    {
                        return "NO";
                    }

                }
            }

            return "YES";
        }

        public static int superDigit(string n, int k)
        {
            long sum = 0;
            if (k > 1 || n.Length > 1)
            {
                for (int j = 0; j < n.Length; j++)
                {
                    sum += Convert.ToInt32((n[j]).ToString());
                }

                return superDigit((sum * k).ToString(), 1);
            }
            else
            {
                return (Convert.ToInt32(n) * k);
            }
        }
        //public static int superDigit(string n, int k) //my failed attempt
        //{
        //    string bruh = null;
        //    for (int i = 0; i < k; i++)
        //    {
        //        bruh = bruh + n;
        //    }

        //    int check = 10000;

        //    long sumNumber = 0;// result of calculating
        //    int returnNumber;

        //    while (check > 1)
        //    {
        //        for (int z = 0; z < bruh.Length; z++)
        //        {
        //            sumNumber = long.Parse(bruh.Substring(z, 1)) + sumNumber;
        //        }

        //        bruh = sumNumber.ToString();

        //        if (sumNumber < 10)
        //        {
        //            check = 0;
        //        }
        //    }
        //    returnNumber = Convert.ToInt32(sumNumber);

        //    return returnNumber;
        //}
    }
}



