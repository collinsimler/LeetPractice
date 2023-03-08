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
    }
}