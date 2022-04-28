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
    class HRHourStyleConvert
    {
       string saaa = "aaaaaaaaaaaaa";

        public string Idiot(string Time)
        {


            return DateTime.Parse(Time).ToString("HH:mm:ss");

            //char dayornight = saaa[saaa.Length - 2];
            //saaa = saaa.Substring(0, saaa.Length - 2);
            //string unsignedTime = saaa.Replace(":", "");
            //int unsignedTimeInt = Convert.ToInt32(unsignedTime);
            //int temp1 = 0;
            //int temp2 = 0;

            //if (dayornight == 'p')
            //{
            //    unsignedTimeInt = unsignedTimeInt + 120000;
            //}

            //char[] helpHELP = (Convert.ToString(unsignedTimeInt.ToString())).ToArray();

            //for(int i = 0; 0 < helpHELP.Length + 1; i++)
            //{
            //    if(i % 2 == 0 && i > 1 && i < 5)
            //    {
            //        for(int z = i; z < helpHELP.Length; z++)
            //        {
            //            temp1 = helpHELP[z + 1];
            //            helpHELP[i + 1] = helpHELP[i];
            //            helpHELP[i] = ':';
            //        }

            //    }
            //}

        }


    }
}
