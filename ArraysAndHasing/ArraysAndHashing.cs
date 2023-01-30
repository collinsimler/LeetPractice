using System.Collections;

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

            if(s.Length != t.Length)//they would have to use every letter so if the length is different, not anagram
            {
                return false;
            }

            Dictionary<char, int> hash = new Dictionary<char, int>();

            for(int i = 0; i < s.Length; i++)
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

            for(int i = 0; i < t.Length; i++)
            {
                if (!hash.ContainsKey(t[i]))//if character is not in string s, automiaclay not a Anagram
                {
                    return false;

                }


                if (hash.ContainsKey(t[i]) && hash[t[i]] != 0) // if it is in string s and not used yet mark as used
                {
                    hash[t[i]] = hash[t[i]] - 1; //use a letter 
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

           if(t.Length != s.Length)
                return false;

            return String.Concat(s.OrderBy(c => c)).Equals(String.Concat(t.OrderBy(c => c)));
              
        }

        public static int[] TwoSums(int[] nums, int target)
        {
            for(int i = 0; i < nums.Length; i++)
            {
                if(nums[i] + nums[i++] == target)
                {
                    return new int[] { nums[i], nums[i++] };
                }
            }

            return null;

        }


    }
}