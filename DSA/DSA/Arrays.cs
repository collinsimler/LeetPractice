namespace DSA
{
    public class Arrays
    {
        /// <summary>
        /// Given an integer array nums sorted in non-decreasing order, remove the duplicates in-place such that each unique element appears only once.
        /// The relative order of the elements should be kept the same.
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static int RemoveDuplicates(int[] nums)
        {
            int newlength = nums.Length;

            for (int i = nums.Length - 1; i > 0; i--)
            {
                if (nums[i - 1] == nums[i])
                {
                   nums = ShiftToLeft(nums, i);
                   newlength--;
                }
            }

            return newlength;
        }

        /// <summary>
        /// Helper Method for RemovingDuplicates, will shift every element in arry to the left starting the provided index
        /// </summary>
        /// <param name="array"></param>
        /// <param name="index"></param>
        /// <returns></returns>
        private static int[] ShiftToLeft(int[] array, int index)
        {

            for (int i = index; i < array.Length - 1; i++)
            {
                array[i] = array[i + 1];

            }

            return array;
        }

        /// <summary>
        /// This is a more optimal solution with O(n) time complexity vs the first solution was O(n^2), this uses the two pointers method 
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static int RemoveDuplicates2(int[] nums)
        {
            int unquieValueIndexPointer = 0;
            

            for (int leadingPointer = 1; leadingPointer < nums.Length; leadingPointer++)
            {
                if(nums[unquieValueIndexPointer] != nums[leadingPointer])
                {
                    unquieValueIndexPointer++;
                    nums[unquieValueIndexPointer] = nums[leadingPointer];

                }
               
            }

            return unquieValueIndexPointer + 1;
        }

        /// <summary>
        /// Given an integer array nums and an integer val, remove all occurrences of val in nums in-place. 
        /// The relative order of the elements may be changed.
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="val"></param>
        /// <returns></returns>
        public static int RemoveElement(int[] nums, int val)
        {
            if(nums == null)
                return 0;

            int Lpointer = 0;

            for(int Rpointer = 0; Rpointer < nums.Length; Rpointer++)
            {
                if( nums[Rpointer] != val)
                {
                    nums[Lpointer] = nums[Rpointer];
                    Lpointer++;
                }
            }

            return Lpointer;
        }

    }
}