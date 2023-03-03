namespace BasicArrays
{
    public class Insertion
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

        /// <summary>
        /// Given a fixed-length integer array arr, duplicate each occurrence of zero, shifting the remaining elements to the right.
        /// </summary>
        /// <param name="arr"></param>
        public static int[] DuplicateZeros(int[] arr)
        {
            for(int i = 0; i < arr.Length; i++)
            {
                if(arr[i] == 0 && i != arr.Length -1)
                {
                    arr = ShiftToRight(arr, i);
                    arr[i+1] = 0;
                    i++;
                }
            }

            return arr;

        }

        public static int[] ShiftToRight(int[] arr, int index)
        {
            for(var i = arr.Length-2; i > index; i--)
            {
                arr[i+1] = arr[i];

            }

            return arr;
        }

        /// <summary>
        /// You are given two integer arrays nums1 and nums2, sorted in non-decreasing order, and two integers m and n, representing the number of elements in nums1 and nums2 respectively.
        /// </summary>
        /// <param name="nums1"></param>
        /// <param name="m"></param>
        /// <param name="nums2"></param>
        /// <param name="n"></param>
        public static int[] Merge(int[] nums1, int m, int[] nums2, int n)
        {
            int i = m - 1,
                j = n - 1,
                k = m + n - 1;

            while (i > -1 && j > -1)
            {
                if (nums1[i] >= nums2[j])
                {
                    nums1[k] = nums1[i--];
                }
                else
                {
                    nums1[k] = nums2[j--];
                }

                k--;
            }

            while (j > -1)
            {
                nums1[k--] = nums2[j--];
            }


            return nums1;

        }
    }
}