using System;
using System.Globalization;

namespace LeetCode_Solutions
{
    public class LongestPalindromicSubstring
    {
        public static string Solution(string word)
        {
            ///<summary>
            ///Takes a string and returns the longest Palindromic substring
            ///within it.
            ///(The longest substring that is the same spelled forward or backward)
            ///</summary>
            string answer = word[0].ToString();
            int i = 0;
            int j = word.Length - 1;
            int currentsubwordlength = word.Length - 1;

            while (currentsubwordlength > 1)
            {

                currentsubwordlength--;
            }

            return answer;
        }
        public static string ReturnSubstring(string word, int index1, int index2)
        {
            ///<summary>
            ///Returns a string of characters in the given word from index1 to index2
            /// </summary>

            string result = "";

            for (int i = index1; i <= index2; i++)
            {
                result += word[i];
            }

            return result;

        }
        public static bool Palindromic(string word)
        {
            ///<summary>
            ///Returns true if the given string of characters is the same spelled
            ///forward and backward.
            ///</summary>
            bool answer = true;
            int j = word.Length - 1;
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == word[j]) 
                {
                    j--;
                    continue; 
                }
                else 
                { 
                    answer = false;
                    break;
                }
            }
            return answer;
        }
    }
}