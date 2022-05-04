using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorihmQuestions
{
    internal class HRCaesarsChiper
    {
        public static string caesarCipher(string s, int k)
        {
            string cipher = "";

            foreach (char c in s)
            {
                if (!char.IsLetter(c))
                {
                    cipher += c;  //if it is not a letter, then adds to the string without changing anything
                }
                else if (char.IsUpper(c))
                {
                    cipher += Convert.ToChar((c + k - 65) % 26 + 65); //ASCII letter values starts from 65 as capital letters
                }
                else
                {
                    cipher += Convert.ToChar((c + k - 97) % 26 + 97); //Smaller letters starts from 97
                }
            }

            return cipher;
        }
    }
}
