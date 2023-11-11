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
            string defaultresponse = "There is no common prefix among the input strings.";
            if( input.Length <= 1 ){ return defaultresponse; }
            if( input[0][0] != input[1][0] ){ return defaultresponse; }
            
            string result = "";
            int shortestword = ShortestWord(input);

            //char loop
            for (int i = 0; i < shortestword; i++)
            {
                bool match = true;
                char tempchar = input[0][i];
                //word loop
                for (int j = 1; j < input.Length; j++)
                {
                    if( tempchar != input[j][i] ) 
                    { 
                        match = false;
                        break;
                    }
                }
                
                if( match ) { result += tempchar; }
                else { break; }
                
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