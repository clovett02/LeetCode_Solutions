using System;
using System.Security.Cryptography.X509Certificates;

namespace LeetCode_Solutions
{
    public class Longest_Common_Prefix
    {
        /// <summary>
        /// Problem: Write a function to find the longest common prefix string amongst an
        /// array of strings.
        /// **Edge Case: if the array is only 1 word long, return that word.
        /// **Edge Case: if the length of any string in the array is 0, return ""
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string Solution(string[] input)
        {
            string result = "";
            int shortestword = ShortestWord(input);
            
            if( input.Length <= 1 ){ return input[0]; }
            if( shortestword == 0 ){ return result; }
            if( input[0][0] != input[1][0] ){ return result; }
            

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
    }
}