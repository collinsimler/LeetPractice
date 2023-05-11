using System.Collections;

namespace Arrays.DSA
{
    public class Array
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
                if (nums[unquieValueIndexPointer] != nums[leadingPointer])
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
            if (nums == null)
                return 0;

            int Lpointer = 0;

            for (int Rpointer = 0; Rpointer < nums.Length; Rpointer++)
            {
                if (nums[Rpointer] != val)
                {
                    nums[Lpointer] = nums[Rpointer];
                    Lpointer++;
                }
            }

            return Lpointer;
        }

        /// <summary>
        /// Given an integer array nums of length n, you want to create an array ans of length 2n where ans[i] == nums[i] and ans[i + n] == nums[i] for 0 <= i < n (0-indexed).
        ///
        /// Specifically, ans is the concatenation of two nums arrays.
        ///
        /// Return the array ans.
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static int[] GetConcatenation(int[] nums)
        {
            int[] doubledArray = new int[nums.Length * 2];

            int numsIndex = 0;

            for (int i = 0; i < doubledArray.Length; i++)
            {
                if (numsIndex == nums.Length)
                    numsIndex = 0;

                doubledArray[i] = nums[numsIndex];

                numsIndex++;

            }

            return doubledArray;
        }

        /// <summary>
        /// You are keeping the scores for a baseball game with strange rules. At the beginning of the game, you start with an empty record.
        ///
        /// You are given a list of strings operations, where operations[i] is the ith operation you must apply to the record and is one of the following:
        ///
        /// An integer x.
        /// Record a new score of x.
        ///
        /// '+'.
        /// Record a new score that is the sum of the previous two scores.
        ///
        /// 'D'.
        /// Record a new score that is the double of the previous score.
        ///
        /// 'C'.
        /// Invalidate the previous score, removing it from the record.
        ///
        /// Return the sum of all the scores on the record after applying all the operations.
        /// </summary>
        /// <param name="operations"></param>
        /// <returns></returns>
        public static int CalPoints(string[] operations)
        {
            Stack<string> ScoreHistory = new Stack<string>();

            for (int i = 0; i < operations.Length; i++)
            {
                int temp;
                if (int.TryParse(operations[i], out temp))
                {
                    ScoreHistory.Push(operations[i]);
                }
                else if (operations[i].Equals("+"))
                {
                    int popped = int.Parse(ScoreHistory.Pop());

                    temp = int.Parse(ScoreHistory.Peek());

                    ScoreHistory.Push(popped.ToString());//push this one back on 
                    ScoreHistory.Push((popped + temp).ToString());



                }
                else if (operations[i].Equals("C"))
                {
                    ScoreHistory.Pop();

                }
                else if (operations[i].Equals("D"))
                {
                    int doubledPrevious = int.Parse(ScoreHistory.Peek()) * 2;
                    ScoreHistory.Push(doubledPrevious.ToString());
                }
            }



            int totalScore = 0;

            foreach (var score in ScoreHistory)
            {
                totalScore += int.Parse(score);
            }


            return totalScore;
        }

        /// <summary>
        /// Given a string s containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static bool IsValid(string s)
        {

            Stack<char> Parentheses = new Stack<char>();

            Dictionary<char, char> map = new Dictionary<char, char>()
            {
                { '}','{'},
                {']','['},
                {')','('}
            };

            foreach (char c in s)
            {
                if (map.ContainsKey(c))
                {
                    if (Parentheses.Count != 0 && Parentheses.Peek().Equals(map[c]))
                        Parentheses.Pop();
                    else
                        return false;
                }
                else
                {
                    Parentheses.Push(c);
                }
            }

            return Parentheses.Count == 0;
        }









    }
}