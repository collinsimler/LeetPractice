namespace DSA
{
    public class Arrays
    {
        /// <summary>
        /// Given an integer array nums sorted in non-decreasing order, remove the duplicates in-place such that each unique element appears only once.
        /// The relative order of the elements should be kept the same.
        ///
        /// Since it is impossible to change the length of the array in some languages, you must instead have the result be placed in the first part of the array nums.
        /// More formally, if there are k elements after removing the duplicates, then the first k elements of nums should hold the final result. It does not matter what you leave beyond the first k elements.
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static int RemoveDuplicates(int[] nums)
        {
            int newlength = nums.Length;

            for (int i = nums.Length - 1; i > 1; i--)
            {
                if (nums[i - 1] == nums[i])
                {
                   nums = ShiftToLeft(nums, i);
                   newlength--;
                }
            }

            return newlength;
        }

        private static int[] ShiftToLeft(int[] array, int index)
        {

            for (int i = index; i < array.Length - 1; i++)
            {
                array[i] = array[i + 1];

            }

            return array;
        }

    }
}