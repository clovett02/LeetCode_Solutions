using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Solutions
{
    public class ZigZagConversion
    {
        /// <summary>
        /// This solution takes a string and returns what the string would be
        /// if printed in a zigzag pattern. The return string returns how it 
        /// would be read from left to right, from row 0 to n.
        /// </summary>
        /// <param name="word"></param>
        /// <param name="rows"></param>
        /// <returns></returns>
        public string Solution(string word, int rows)
        {
            string answer = "";
            string[,] array_answer = new string[rows, this.ReturnNumberofColumns(word, rows)];
            int i = 0; //tracks word index
            int j = 0; //tracks row index
            int k = 0; //tracks column index

            while (i < word.Length)
            {
                j = 0;
                while (j <= rows && i < word.Length)
                {
                    array_answer[j, k] = word[i].ToString();
                    i++;
                    j++;
                }
                j -= 2;
                k++;
                while (j > 0)
                {
                    array_answer[j, k] = word[i].ToString();
                    i++;
                    j--;
                    k++;
                }
            }

            return answer;
        }

        public string[,] Return2DArray(string word, int numrows, int numcolumns)
        {
            string[,] result = new string[numrows, numcolumns];

            return result;
        }

        public int ReturnNumberofColumns(string word, int rows)
        {
            int result = 0;
            // if (word.Length > 0) { result = 1; }
            int i = 0, j = 0;
            while(i < word.Length)
            {
                j = 0;
                result++;
                while (j < rows && i < word.Length)
                {
                    i++;
                    j++;
                }
                
                j -= 2;
                while(j > 0 && i < word.Length)
                {
                    i++;
                    j--;
                    if(j > 0) { result++; }
                }
            }

            return result;
        }
    }
}


/// 5 chars 2 rows means 3 columns
/// 5 chars 3 rows means 2 columns
