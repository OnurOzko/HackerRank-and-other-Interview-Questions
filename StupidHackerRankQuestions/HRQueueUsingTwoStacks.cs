using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.IO;

namespace StupidHackerRankQuestions
{

    class HRQueueUsingTwoStacks
    {
        static void bruh(String[] args)
        {
            /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
            string strLength = Console.ReadLine();
            int length = Convert.ToInt32(strLength);
            string[] myArr = new string[length];
            //int total = 0;
            int temp = 0;

            for (int i = 0; i < length; i++)
            {
                myArr[length - (1 + i)] = Console.ReadLine();
            }

            int loopLength = length - 1;

            // for(int i = 0; i < loopLength; i++){
            //     if(myArr[i][0] == 1){
            //         total++
            //     }
            //     else if(myArr[i][1] == 2){
            //         total--
            //     }
            // }

            int[] queue = new int[loopLength];

            for (int i = 0; i < loopLength; i++)
            {
                if (Convert.ToInt32(myArr[i][0]) == 1)
                {
                    queue[loopLength - (i + 1)] = Convert.ToInt32(myArr[i][1]);
                }
                else if (Convert.ToInt32(myArr[i][0]) == 2)
                {
                    for (int z = 0; z < loopLength; z++)
                    {
                        if ((loopLength - (z + 2)) >= 0)
                            queue[loopLength - (z + 1)] = queue[loopLength - (z + 2)];
                    }
                }
                else if (Convert.ToInt32(myArr[i][0]) == 3)
                {
                    Console.WriteLine(queue[loopLength - 1]);
                }
            }

            // for(int i = 0; i < length; i++){
            //     Console.WriteLine(myArr[i]);
            // }


        }//end of method
    }//end of class

}
