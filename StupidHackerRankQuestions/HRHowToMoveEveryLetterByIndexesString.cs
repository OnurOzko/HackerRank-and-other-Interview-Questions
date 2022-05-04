using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorihmQuestions
{
    internal class HRHowToMoveEveryLetterByIndexesString
    {
        public static string moveCharactersByK(string s, int k)
        {
            //string symbols = @"\b[hH]\w*\b";
            //// MatchCollection matches = Regex.Match(k, symbols); //using regex to find symbol locations
            //int index = Array.IndexOf(symbols, s);



            char[] dividedString = s.ToCharArray();
            char[] orderedString = new char[s.Length];
            //Array.Clear(orderedString, 0, orderedString.Count);
            int stringLength = orderedString.Length;

            for (int i = 0; i < stringLength; i++)
            {
                if (k > i)
                {
                    orderedString[stringLength - k + i] = dividedString[i];
                }
                else
                {
                    orderedString[i - k] = dividedString[i];
                }
            }

            s = orderedString.ToString();

            return s;


        }
    }
}
