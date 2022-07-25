

namespace LeetCodeProblemTesting
{
    public class EasyProblems
    {

        public static void testCodeMeth()
        {
            string myString = "string";
            // outputs r
            Console.WriteLine(myString[2]);


        }


        public static bool IsPalindrome(int x)
        {
            //cant be negative, less than 10 or equal to 0
            if (x < 0 || (x % 10 == 0 && x != 0))
            {
                return false;
            }

            int revertedNumber = 0;
            while (x > revertedNumber)
            {
                revertedNumber = revertedNumber * 10 + x % 10;
                x /= 10;
            }


            return x == revertedNumber || x == revertedNumber / 10;

        }


        public static int RomanToInt(string romanNumber)
        {

            int convertedNum = 0;

            for(int i = 0; i < romanNumber.Length; i++)
            {
                

                if (romanNumber[i].ToString().Equals("I"))
                {
                    if (romanNumber.Length - 1 != i && romanNumber[i+1].ToString().Equals("V"))
                    {
                        convertedNum += 4;
                        i++;
                    }
                    else if (romanNumber.Length - 1 != i && romanNumber[i+1].ToString().Equals("X"))
                    {
                        convertedNum += 9;
                        i++;
                    }
                    else
                    {
                        convertedNum++;

                    }



                }
                else if (romanNumber[i].ToString().Equals("V"))
                {
                    convertedNum += 5;

                }
                else if (romanNumber[i].ToString().Equals("X"))
                {
                    if (romanNumber.Length - 1 != i && romanNumber[i+1].ToString().Equals("L"))
                    {
                        convertedNum += 40;
                        i++;
                    }
                    else if (romanNumber.Length - 1 != i && romanNumber[i+1].ToString().Equals("C"))
                    {
                        convertedNum += 90;
                        i++;
                    }
                    else
                    {
                        convertedNum += 10;

                    }

                }
                else if (romanNumber[i].ToString().Equals("L"))
                {
                    convertedNum += 50;

                }
                else if (romanNumber[i].ToString().Equals("C"))
                {
                    if (romanNumber.Length - 1 != i && romanNumber[i+1].ToString().Equals("D"))
                    {
                        convertedNum += 400;
                        i++;
                    }
                    else if (romanNumber.Length - 1 != i && romanNumber[i+1].ToString().Equals("M"))
                    {
                        convertedNum += 900;
                        i++;
                    }
                    else
                    {
                        convertedNum += 100;

                    }
                }
                else if (romanNumber[i].ToString().Equals("D"))
                {
                    convertedNum += 500;

                }
                else if (romanNumber[i].ToString().Equals("M"))
                {
                    convertedNum += 1000;

                }


            }

            return convertedNum;

        }


        public static bool ValidParentheses(string s)
        {

            if (s[0].ToString().Equals(")") || s[0].ToString().Equals("}") || s[0].ToString().Equals("]"))
                return false;

            Stack<string> stack = new Stack<string>();

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i].ToString().Equals("("))
                {
                    stack.Push(s[i].ToString());

                }
                else if (s[i].ToString().Equals("{"))
                {
                    stack.Push(s[i].ToString());

                }
                else if (s[i].ToString() == "[")
                {
                    stack.Push(s[i].ToString());

                }
                else if (s[i].ToString().Equals(")"))
                {


                    if (stack.Count == 0 || !stack.Pop().Equals("("))
                    {
                        return false;
                    }

                }
                else if (s[i].ToString().Equals("]"))
                {



                    if (stack.Count == 0 || !stack.Pop().Equals("["))
                    {
                        return false;
                    }

                }
                else if (s[i].ToString().Equals("}"))
                {


                    if (stack.Count == 0 || !stack.Pop().Equals("{"))
                    {
                        return false;
                    }

                }

            }

            return stack.Count == 0;

        }

        public static int[] TwoSum(int[] nums, int target)
        {
            for(int i = 0; i < nums.Length; i++)
            {
                for(int j = 1; j < nums.Length; j++)
                {
                    if(nums[i]+nums[j] == target)
                    {
                        int[] returner = new int[] { i, j };
                        return returner;
                    }

                }
            }

            return nums;
        }


        public int[] RunningSum(int[] nums)
        {

            int[] returner = new int[nums.Length];

            for (int i = 0; i < nums.Length; i++)
            {

                int item = 0;
                for(int j = 0; j <= i; j++)
                {
                    item += nums[j];
                }
                
                returner.SetValue(item,i);

            }
            return returner;
        }



        public static int PivotIndex(int[] nums)
        {

            int numbersLeft = 0;
            int Total = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                Total += nums[i];
            }

            int numbersRight = Total;

            //check for if zero
            if (Total - nums[0] == 0)
                return 0;

            for (int i = 1; i < nums.Length; i++)
            {

                numbersLeft += nums[i - 1];
                numbersRight = Total - numbersLeft - nums[i];

                if (numbersLeft == numbersRight)
                {
                    return i;
                }

            }


            //if no solution is found return -1
            return -1;
        }




    }



}