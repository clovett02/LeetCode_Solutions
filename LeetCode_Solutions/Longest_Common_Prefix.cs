using System;

namespace LeetCode_Solutions
{
    public class Longest_Common_Prefix
    {
        /// <summary>
        /// Problem: Write a function to find the longest common prefix string amongst an
        /// array of strings.
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string Solution(string[] input)
        {
            string result = "";

            //word loop
            for (int i = 0; i < input.Length; i++)
            {
                int shortestword = ShortestWord(input);

                //char loop

                
            }

            return result;
        }
        public static int ShortestWord(string[] input)
        {
            int result = 0;
            if(input.Length > 0){result = input[0].Length;}
            else{return 0;}
            
            for (int i = 0; i < input.Length; i++)
            {
                if(input[i].Length < result){ result=input[i].Length; }
            }
            return result;
        }
        public static bool CharMatch(string word1, string word2, int charnumber)
        {
            if(word1[charnumber] == word2[charnumber]){return true;}
            else{return false;}
        }
    }
}