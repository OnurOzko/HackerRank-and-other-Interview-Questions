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

    class HRQueueUsingTwoStacks // 4 / 16
    {
        static void bruh(String[] args)
        {
            /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
            string strLength = Console.ReadLine();
            int length = Int32.Parse(strLength);
            string[] myArr = new string[length];
            //int total = 0;
            int temp = 0;
            string tempStr;
            int lastElementIndex = 0;
            int firstElementIndex = 0;

            for (int i = 0; i < length; i++)
            {
                // myArr[length - (1 + i)] = Console.ReadLine();
                myArr[i] = Console.ReadLine();
            }

            int loopLength = myArr.Length;


            // Console.WriteLine(length);
            // Console.WriteLine(loopLength);
            // Console.WriteLine(myArr);

            // for(int i = 0; i < loopLength; i++){
            //     Console.WriteLine(myArr[i]);
            // }



            int[] queue = new int[loopLength];

            for (int i = 0; i < loopLength - 1; i++)
            {

                // Console.WriteLine("Start of Array at i :" + i);
                // for(int meh = 0; meh < loopLength; meh++){
                //     Console.WriteLine(queue[meh]);
                // }
                // Console.WriteLine("End of Array at i :" + i); //for debugging

                tempStr = myArr[i].Split(' ')[0];
                if (tempStr == "1")
                {
                    tempStr = myArr[i].Split(' ')[1];

                    if (queue[0] == 0)
                    {
                        queue[0] = Int32.Parse(tempStr);
                    }

                    else if (queue[loopLength - 1] != 0)
                    {
                        for (int z = 0; z < loopLength; z++)
                        {
                            queue[z] = queue[z + 1];
                        }
                        queue[loopLength] = Int32.Parse(tempStr);
                    }
                    else
                    {
                        firstElementIndex = Array.IndexOf(queue, 0);
                        queue[firstElementIndex] = Int32.Parse(tempStr);
                    }
                }

                else if (tempStr == "2")
                {
                    if (queue[0] == 0) { }
                    else if (queue[1] == 0)
                    {
                        queue[0] = 0;
                    }
                    else
                    {
                        //firstElementIndex = Array.IndexOf(queue, 0);
                        for (int z = 0; z < loopLength - 1; z++)
                        {
                            queue[z] = queue[z + 1];
                        }
                        queue[loopLength - 1] = 0;
                    }

                }
                else if (tempStr == "3")
                {
                    Console.WriteLine(queue[0]);
                }
                // else{
            }

            // for(int i = 0; i < length; i++){
            //     Console.WriteLine(myArr[i]);
            // }


        }//end of method
    }//end of class

}
