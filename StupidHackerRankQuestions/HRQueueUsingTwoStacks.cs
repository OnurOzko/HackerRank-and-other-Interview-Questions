using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AlgorihmQuestions
{
    class HRQueueUsingTwoStacks // 16 / 16 success rate
    {
        static void queueClass() // 16 / 16 success rate
        {
            /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
            int intLength = Int32.Parse(Console.ReadLine());
            Queue<string> numbers = new Queue<string>();
            string tempStr;
            string loopStr;

            for (int i = 0; i < intLength - 1; i++)
            {
                tempStr = Console.ReadLine();
                loopStr = tempStr.Split(' ')[0];
                switch (loopStr)
                {
                    case "1": //push
                        tempStr = tempStr.Split(' ')[1];
                        if (numbers.Count == intLength)
                        {
                            numbers.Dequeue();
                            numbers.Enqueue(tempStr);
                        }
                        else
                        {
                            numbers.Enqueue(tempStr);
                        }
                        break;
                    case "2": //pop
                        if (numbers.Count > 0)
                        {
                            numbers.Dequeue();
                        }
                        break;
                    case "3": //print first element of queue
                        if (numbers.Count > 0)
                        {
                            Console.WriteLine(numbers.Peek());
                        }
                        else
                        {
                            Console.WriteLine("0");
                        }
                        break;
                }
            }//end of main loop
            tempStr = Console.ReadLine().Split(' ')[0]; //in case our last number is a print
            if (tempStr == "3" && numbers.Count > 0)
            {
                Console.WriteLine(numbers.Peek());
            }
            else if (tempStr == "3")
            {
                Console.WriteLine("0");
            }
        }//end of method

        //--------------------------------------------------------------> ----------------------------- < ---------------------------------------------------------------//

        static void bruhArray() //done by using arrays, works well but not efficient enough to pass the runtime limit in 4 examples. (12/16 Success Rate)
        {
            /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
            string strLength = Console.ReadLine();
            int length = Int32.Parse(strLength);
            //string[] myArr = new string[length];
            string tempStr;
            int firstElementIndex = 0;
            int tempInt;

            int loopLength = Int32.Parse(strLength);
            int[] queue = new int[loopLength];

            for (int i = 0; i < loopLength - 1; i++)
            {

                tempStr = Console.ReadLine();
                tempInt = Int32.Parse(tempStr.Split(' ')[0]);

                switch (tempInt)
                {
                    case 1: //push
                        tempInt = Int32.Parse(tempStr.Split(' ')[1]);
                        if (queue[0] == 0)
                        {
                            queue[0] = tempInt;
                        }
                        else if (queue[loopLength - 1] != 0)
                        {
                            for (int z = 0; z < loopLength; z++)
                            {
                                queue[z] = queue[z + 1];
                            }
                            queue[loopLength] = tempInt;
                        }
                        else
                        {
                            firstElementIndex = Array.IndexOf(queue, 0);
                            queue[firstElementIndex] = tempInt;
                        }
                        break;
                    case 2: //pop
                        if (queue[0] == 0 || queue[1] == 0)
                        {
                            queue[0] = 0;
                        }
                        else
                        {
                            firstElementIndex = Array.IndexOf(queue, 0);
                            for (int z = 0; z < firstElementIndex; z++)
                            {
                                queue[z] = queue[z + 1];
                            }
                            queue[firstElementIndex] = 0;
                        }
                        break;
                    case 3: //print first element of queue
                        Console.WriteLine(queue[0]);
                        break;
                }
            }//end of main loop
            tempStr = Console.ReadLine();
            tempInt = Int32.Parse(tempStr.Split(' ')[0]);
            if (tempInt == 3)
            {
                Console.WriteLine(queue[0]);
            }
        }//end of method
    }//end of class
}
