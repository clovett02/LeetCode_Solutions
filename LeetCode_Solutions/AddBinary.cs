using System;

namespace LeetCode_Solutions
{
    public class AddBinary
    {
        public static string ReverseString(string word)
        {
            string result = "";

            for (int i = word.Length - 1; i >= 0; i--)
            {
                result += word[i];
            }
            return result;
        }
        public static string AddReversedBinaryStrings(string longernum, string shorternum)
        {
            string result = "";

            for (int i = 0; i < longernum.Length; i++)
            {
                if(i < shorternum.Length)
                {
                    int answer = Convert.ToInt16(shorternum[i]) + Convert.ToInt16(longernum[i]);
                    result += Convert.ToString(answer);
                }
                else { result += longernum[i]; }
            }

            return result;
        }
        public string Solution(string num1, string num2)
        {
            string result = "";
            if (num1.Length > num2.Length)
            {
                result = ReverseString(AddReversedBinaryStrings(longernum: num1, shorternum: num2));
            }
            else
            {
                result = ReverseString(AddReversedBinaryStrings(longernum:num2, shorternum: num1));
            }

            return result;
        }
    }
}