using System;
using System.Collections.Generic;
using System.Globalization;
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

        /*  
        [1,3,5,6,9]  LL

        
         */
        public static void LeftRotateArray(int[] array)
        {
            if(array.Length == 0) return;
            var temp = array[0];
            for(int i = 1; i < array.Length-1; i++)
            {
                array[i - 1] = array[i];
            }
            array[array.Length-1] = temp;

            Console.WriteLine(String.Join(",",array));

        }

        public static void SwapNumbersWithoutTemp(int a,int b)
        {
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine($"a:{a} b:{b}");
        }

        public static int[] ReverseArray(int[] inputArray)
        {
            if(inputArray.Length == 0) return new int[0];
         
            int start = 0;
            int end = inputArray.Length - 1;
            while(start < end)
            {
                int temp = inputArray[start];
                inputArray[start] = inputArray[end];
                inputArray [end] = temp;
            
                start++;
                end--;
            }   
            return inputArray;
        }

        public static int FindUniqueElement(int[] array)
        {
            int ans = 0;
            for(int i = 0; i < array.Length; i++)
            {
                ans = ans ^ array[i];
            }
            return ans;
        }

        public static int[] FindMultipleDuplicates(int[] array)
        {
            List<int> ans = new List<int>();
            int result = 0;
            var hashSet = new HashSet<int>();
            for(int i = 0; i < array.Length; i++)
            {
                result = result ^ array[i];
                hashSet.Add(array[i]);
            }

            for(int j = 1; j < array.Length; j++)
            {
                result = result ^ j;
            }

            return ans.ToArray();
        }

        /// <summary>
        /// remove inplace duplicate elements from an array and keep it in a initial index and rest other 
        /// elements will remain as it is 
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public static int RemoveDuplicateElement(int[] array)
        {

            int i = 0;
            for(int j = 1; j < array.Length; j++)
            {
                if(array[j] != array[i])
                {
                    array[i + 1] = array[j];
                    i++;
                }
            }
            return (i + 1);
        }

        /// <summary>
        /// This method will loop through entire array and moves back item if it is not matching with the 
        /// previous item. By doing this all the duplicates elements are moved to end of the array and it will 
        /// return the index of the middle element from where duplicates are started. From this index we can print the
        /// element which will not have any duplicate elemenet.
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static int RemiveDuplicatesFromArray(int[] arr)
        {
            int md = 0;
            for(int i = 1; i < arr.Length; i++)
            {
                if (arr[md] != arr[i])
                {
                    md++;
                    arr[md] = arr[i];
                }
            }
            return md+1;
        }

        /// <summary>
        /// This is a 2 pointer  approach where one pointer points to array 1 and another points to array2
        /// </summary>
        /// <param name="array1"></param>
        /// <param name="array2"></param>
        /// <returns></returns>
        public static List<int> FindInterSectionOfArray(int[] array1, int[] array2)
        {
            int i=0, j = 0;
            List<int> result = new List<int>();
            Array.Sort(array1);
            Array.Sort(array2);

            while(i <array1.Length && j < array2.Length)
            {
               
                if (array1[i] == array2[j])
                {
                    result.Add(array1[i]);
                    i++;
                    j++;
                }
                else if (array1[i] > array2[j])
                {
                    j++;
                }
                else
                {
                    i++;
                }
            }

            return result;
        }

        public static List<List<int>> FindPairSum(int[] array,int sum)
        {
           List<List<int>> ans = new List<List<int>>();
           
           for(int i = 0; i < array.Length; i++)
           {
                for(int j=1;j<array.Length; j++)
                {
                    if (array[i] + array[j] == sum)
                    {
                        var pair = new List<int>();

                        pair.Add(array[i]);
                        pair.Add(array[j]);

                        ans.Add(pair);
                    }
                }
            }

            return ans;
        }

        /// <summary>
        /// Sort 0 and 1 in an array. Here we can take 2 pointers approach where one pointer i can point to start of the array
        /// and right pointer can points to end of an array. 
        /// If i finds 0 then increment its value
        /// If j finds 1 then decrement its value
        /// If i is 1 and j is 0 then swap these values of these positions
        /// Do this until left and right pointers are not same( come to middle of array)
        /// </summary>
        /// <param name="array"></param>
        public static void SortZeorsOnes(int[] array)
        {
            int left = 0;
            int right = array.Length - 1;

            while(left <= right)
            {
                if(array[left] == 0)
                {
                    left++;
                }
                else if (array[right] == 1)
                {
                    right--;
                }
                else if (array[left] == 1 && array[right] == 0)
                {
                    int temp = array[left];
                    array[left] = array[right];
                    array[right] = temp;

                    left++;
                    right--;

                }
            }
        }


        public static void SortZeroOnesTwos(int[] array)
        {
            int mid, left = 0;
            int high = array.Length - 1;

            
        }
    }
   
}
