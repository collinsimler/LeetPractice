using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicArrays
{
    public class Search
    {
        /// <summary>
        /// Given an array arr of integers, check if there exist two indices i and j such that :
        ///
        ///  - i != j
        ///  - 0 <= i, j < arr.length
        ///  - arr[i] == 2 * arr[j]
        /// 
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static bool CheckPairExists(int[] arr)
        {
            HashSet<int> hashSet = new HashSet<int>();

            for (int i = 0; i < arr.Length; i++)
            {
                if (hashSet.Contains(arr[i]*2))
                {
                    return true;
                }
                else if (hashSet.Contains(arr[i] / 2) && arr[i] % 2 == 0)
                {
                    return true;
                }
                else
                {
                    hashSet.Add(arr[i]);
                }
            }

            return false;

        }

        /// <summary>
        /// Given an array of integers arr, return true if and only if it is a valid mountain array.
        /// </summary>
        /// <param name="arr"></param>
        public static bool ValidMountainArray(int[] arr)
        {
            int increasingRate = 0;
            int decreasingRate = 0;

            for (int i = 0; i < arr.Length - 1; i++)
            {
                int nextTwo = arr[i+1] - arr[i];


                if (increasingRate == 0)
                {
                    increasingRate = nextTwo;
                }
                else if (nextTwo != increasingRate && arr[i] < arr[i+1])
                {
                    return false;
                }
                else if (arr[i] > arr[i + 1] && decreasingRate == 0)
                {
                    decreasingRate = nextTwo;
                }
                else if (nextTwo != decreasingRate && arr[i] > arr[i + 1])
                {
                    return false;
                }

            }

            if (increasingRate == 0 || decreasingRate == 0)
                return false;

            return true;
        }

    }
}
