namespace ArraysAndHasing
{
    public class ArraysAndHashing
    {
        /// <summary>
        /// Check if there are any duplicates in the int array
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static bool ContainsDuplicate(int[] nums)
        {
            Dictionary<int, int> hash = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (hash.ContainsKey(nums[i]))
                {
                    return true;
                }
                else
                {
                    hash.Add(nums[i], nums[i]);
                }

            }

            return false;
        }

        /// <summary>
        /// returns true if they are anagrams using a Dictionary (hash)
        /// </summary>
        /// <param name="s"></param>
        /// <param name="t"></param>
        /// <returns></returns>
        public static bool IsAnagram(string s, string t)
        {

            if (s.Length != t.Length)//they would have to use every letter so if the length is different, not anagram
            {
                return false;
            }

            Dictionary<char, int> hash = new Dictionary<char, int>();

            for (int i = 0; i < s.Length; i++)
            {
                if (hash.ContainsKey(s[i]))
                {
                    hash[s[i]]++; //add a use of the letter
                }
                else
                {
                    hash.Add(s[i], 1); //add letter
                }


            }

            for (int i = 0; i < t.Length; i++)
            {
                if (!hash.ContainsKey(t[i]))//if character is not in string s, automiaclay not a Anagram
                {
                    return false;

                }


                if (hash.ContainsKey(t[i]) && hash[t[i]] != 0) // if it is in string s and not used yet mark as used
                {
                    hash[t[i]]--; //use a letter 
                }
                else if (hash.ContainsKey(t[i]))//if in string s but used already then not a anagram
                {
                    return false;
                }

            }

            return true;


        }

        /// <summary>
        /// return true if they are ordered alphabeicly and they are equal to eachother than they are anagrams.
        /// </summary>
        /// <param name="s"></param>
        /// <param name="t"></param>
        /// <returns></returns>
        public static bool IsAnagramSortMethod(string s, string t)
        {

            if (t.Length != s.Length)
                return false;

            return String.Concat(s.OrderBy(c => c)).Equals(String.Concat(t.OrderBy(c => c)));

        }

        /// <summary>
        /// Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public static int[] TwoSums(int[] nums, int target)
        {

            Dictionary<int, int> hash = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i];//"Look" for matching pair

                if (hash.ContainsKey(complement))//check if pair is already in hash
                {
                    return new int[] { hash[complement], i };
                }
                else
                {
                    hash[nums[i]] = i;
                }
            }

            return null;

        }

        /// <summary>
        /// Given an array of strings strs, group the anagrams together. You can return the answer in any order.
        /// </summary>
        /// <param name="strs"></param>
        /// <returns></returns>
        public static IList<IList<string>> GroupAnagrams(string[] strs)
        {
            Dictionary<string, List<string>> groupedAnies = new Dictionary<string, List<string>>();

            List<IList<string>> res = new List<IList<string>>();

            for (int i = 0; i < strs.Length; i++)
            {
                string orderedString = string.Concat(strs[i].OrderBy(x => x));

                if (!groupedAnies.ContainsKey(orderedString))
                    groupedAnies[orderedString] = new List<string>();

                groupedAnies[orderedString].Add(strs[i]);

            }

            //convert dictionary to list of list
            foreach (List<string> group in groupedAnies.Values)
            {
                res.Add(group);
            }

            return res;

        }

        public static int[] TopKFrequent(int[] nums, int k)
        {
            Dictionary<int, int> hashMap = new Dictionary<int, int>();

            int[] result = new int[k];

            //generate hashMap based on key occurence in the nums array
            for (int i = 0; i < nums.Length; i++)
            {
                if (hashMap.ContainsKey(nums[i]))
                {
                    hashMap[nums[i]]++;
                }
                else
                {
                    hashMap.Add(nums[i], 1);
                }
            }
            
            return hashMap.OrderByDescending(x => x.Value).Select(x => x.Key).Take(k).ToArray();
        }


    }
}