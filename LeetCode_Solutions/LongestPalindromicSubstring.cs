using System;
using System.Globalization;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace LeetCode_Solutions
{
    public class LongestPalindromicSubstring
    {
        public string Solution(string word)
        {
            ///<summary>
            ///Takes a string and returns the longest Palindromic substring
            ///within it.
            ///(The longest substring that is the same spelled forward or backward)
            ///</summary>
            if (this.Palindromic(word)) { return word; }
            string answer = word[0].ToString();
            int wordstart = 0;
            int wordend = word.Length - 1;
            int currentsubwordlength = word.Length - 1;

            while (currentsubwordlength > 1)
            {
                string substring1 = ReturnSubstring(word, wordstart, currentsubwordlength);
                string substring2 = ReturnSubstring(word, wordend - currentsubwordlength, wordend);
                string substring3 = "";
                int i = 0;

                if (this.Palindromic(substring1)) 
                { 
                    answer = substring1;
                    break;
                }
                else if (this.Palindromic(substring2))
                {
                    answer = substring2;
                    break;
                }
                else
                {
                    while (i + currentsubwordlength <= word.Length)
                    {
                        substring3 = word.Substring(i, currentsubwordlength);
                        if (this.Palindromic(substring3))
                        {
                            answer = substring3;
                            return answer;
                        }
                        i++;
                    }
                } 
                 

                currentsubwordlength--;
            }

            return answer;
        }
        public string ReturnSubstring(string word, int index1, int index2)
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
        public bool Palindromic(string word)
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