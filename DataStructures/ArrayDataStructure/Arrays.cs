using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.ArrayDataStructure
{
    public static class Arrays
    {
        /* Find the largest element from the array
          1.Brut force approach :
             - Sort the array
             - Get the last element of the array which is Max number 
            Time : O(nlogn)
            Space : O(1)
          2. Optimized approach
           - Create an variable maxElement and assign the first element of the array
           - Check if the next element of the array is larger than the maxElement,If yes then assign
             next element to maxElement. At the end, maxElement will have the highest integer
         */
        public static int GetMaxElementOfArray(int[] arr)
        {
            if (arr.Length == 0) return 0;

            var maxElement = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > maxElement)
                {
                    maxElement = arr[i];
                }
            }
            return maxElement;
        }
    }
}
