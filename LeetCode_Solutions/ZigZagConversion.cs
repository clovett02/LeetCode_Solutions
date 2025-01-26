using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.XPath;

namespace LeetCode_Solutions
{
    public class ZigZagConversion
    {
        /// <summary>
        /// This solution takes a string and returns what the string would be
        /// if printed in a zigzag pattern. The return string returns how it 
        /// would be read from left to right, from row 0 to n.<br/>
        /// ('abcde', 3) would print:<br/>
        /// a e<br/>
        /// b d<br/>
        /// c<br/>
        ///**Except add one more space to the 1st line between 'a' and 'e'
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
        public int ReturnNumberofColumns(string word, int rows)
        {
            int ReturnColumnsBetween(int rows)
            { 
                int result = rows - 2;
                if ( result <= 0){ return 0; }
                else { return result; }
             }

            if (word.Length <= rows) { return 1; }

            int columnsbetween = ReturnColumnsBetween(rows);

            if (word.Length < rows + columnsbetween) { return word.Length - rows + 1 ; }

            int colsLeft = (word.Length % (rows + columnsbetween));

            int fulliterations = (int)Math.Floor((double) word.Length / (rows + columnsbetween));

            int result = (fulliterations * (columnsbetween + 1)) + colsLeft;

            Console.WriteLine($"Word Length: {word.Length}\n # Rows: {rows}\n Result: {result}");
            return  result;
        }

    }
}
