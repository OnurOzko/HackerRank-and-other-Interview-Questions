using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorihmQuestions
{
    class HRCountingSort
    {

        static public List<int> firstStepofCountingSort(List<int> arr)
        {
            int[] occurences = new int[100];
            foreach (var item in arr)
                occurences[item]++;

            return occurences.ToList();
        }




        /* public List<int> mrCountingSort(List<int> arr) I thought question was about writing counting sort but it wasn't, I failed it anyway.
        {
            //Take a count array to store the count of each unique object.

            int sortLength = arr.Count();  //obviously length of the array
            int biggestNumber = arr.Max(); //we get the biggest number so that we can create the array below as we are going to count amount of repeating each value does

            //another array to keep the repeatings of each value. For example if there are 6 2s in an array, index of 2 will become 6.
            //Since int is a value type, all elements are initilialized to 0 as a default. But if we wanted to manually assign it: 
            //we would had to use: Array.Clear(array, 0, array.Length);
            int[] index = new int[biggestNumber + 1];

            for(int i = 0; i < biggestNumber; i++) //store count of each value in related index
            {
                index[arr[i]]++;
            }

            //then we modify our count storage array by adding each previous index's value to on it's own

            for(int i = 0; i < biggestNumber - 1; i++)
            {
                index[i + 1] = index[i] + index[i + 1];
            }

            //now we are going to get the biggest VALUE!!!! number of our count storage to create an array by using it's size

            int biggestCounterNumber = index.Max();
            int [] places = new int[biggestCounterNumber];

            //we are going to place the values from arr by using values from our second array(int[] index) as indexes to sort our first array to our newly created one
            //and decrease values in our valueRepeatings by one

            for(int i = 0; i < biggestCounterNumber; i++)
            {
                //  = arr.IndexOf(i);
                places[i] = index[arr[i]];
                index[i] = index[i] - 1; //we are going to decrease the value in our index of the one we used!
            }   

            List<int> result = places.ToList();

            return result;
        } */
    }
}
