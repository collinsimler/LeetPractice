namespace BasicArrays
{
    public class BasicArrays
    {
        /// <summary>
        /// Given a binary array nums, return the maximum number of consecutive 1's in the array.
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static int FindMaxConsecutiveOnes(int[] nums)
        {

            int currentOnes = 0;
            int MaxConsecutive = 0;

            for (int i = 0; i < nums.Length; i++)
            {

                if (nums[i] == 1)
                {

                    currentOnes++;

                    if (currentOnes > MaxConsecutive)
                    {
                        MaxConsecutive = currentOnes;
                    }

                }
                else
                {
                    currentOnes = 0;
                }

            }

            return MaxConsecutive;
        }

        /// <summary>
        /// Given an array nums of integers, return how many of them contain an even number of digits.
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static int FindNumbers(int[] nums)
        {

            int numOfEvenDigits = 0;

            for (int i = 0; i < nums.Length; i++)
            {

                int numOfDigits = 0;

                while (nums[i] != 0)
                {
                    nums[i] = nums[i] / 10;
                    numOfDigits++;
                }

                if (numOfDigits % 2 == 0 && numOfDigits != 0)
                {
                    numOfEvenDigits++;
                }

            }

            return numOfEvenDigits;

        }

        /// <summary>
        /// Given an integer array nums sorted in non-decreasing order, return an array of the squares of each number sorted in non-decreasing order.
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static int[] SortedSquares(int[] nums)
        {

            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = (int)Math.Pow(nums[i], 2);
            }

           Array.Sort(nums);

            return nums;
        }

    }
}