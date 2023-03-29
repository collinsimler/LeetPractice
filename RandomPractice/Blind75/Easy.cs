namespace Blind75
{
    public static class Easy
    {

        public static int MissingNumber(int[] nums)
        {

            Dictionary<int, int> numberCounts = new Dictionary<int, int>();

            foreach (int num in nums)
            {
                numberCounts.Add(num, 1);
            }

            for (int i = 0; i < nums.Length; i++)
            {
                if (!numberCounts.ContainsKey(i))
                {
                    return i;
                }
            }

            //return 0 if none found
            return 0;
        }

        public static bool ContainsDuplicate(int[] nums)
        {
            Dictionary<int,int> numberCounts = new Dictionary<int, int>();

            foreach (int num in nums)
            {
                if (numberCounts.ContainsKey(num))
                    return true;

                numberCounts.Add(num,1);
            }

            return false;
        }

        public static bool IsAnagram(string s, string t)
        {

            Dictionary<char, int> characterCountsS = new Dictionary<char, int>();

            foreach (var character in s)
            {
                if (characterCountsS.ContainsKey(character))
                {
                    characterCountsS[character]++;
                }
                else
                {
                    characterCountsS.Add(character,1);
                }
            }

            foreach (char c in t)
            {
                if (characterCountsS.ContainsKey(c))
                {
                    characterCountsS[c]--;
                    
                }
                else
                {
                    return false;
                }

                if (characterCountsS[c] < 0)
                    return false;

            }

            foreach (var i in characterCountsS)
            {
                if (i.Value > 0)
                {
                    return false;
                }
            }

            return true;

        }

        public static int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> indices = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                int difference = target - nums[i];

                if(indices.ContainsKey(difference))
                    return new int[] { indices[difference], i };
            }

            return null;
        }

        public static int MaxProfit(int[] prices)
        {

        }





    }
}