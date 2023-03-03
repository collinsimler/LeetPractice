using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicArrays
{
    public class Deletion
    {
        /// <summary>
        /// Given an integer array nums and an integer val, remove all occurrences of val in nums in-place. The relative order of the elements may be changed.
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="val"></param>
        /// <returns></returns>
        public static int RemoveAllElements(int[] nums, int val)
        {
            int k = nums.Length;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == val)//found integer with matching value
                {
                    ShiftLeft(nums, i); //shift whole array to left to remove number and keep every value together
                    k--;
                }
            }


            return k;
        }

        public static int[] ShiftLeft(int[] nums, int index)
        {
            for (int i = index + 1; i < nums.Length; i++)
            {
                nums[i - 1] = nums[i];
            }

            return nums;
        }
    }
}
