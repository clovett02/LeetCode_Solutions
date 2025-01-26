using System;

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
        /// <param name="s"></param>
        /// <param name="numRows"></param>
        /// <returns></returns>
        public string Solution(string s, int numRows)
        {
            string answer = "";
            string[,] array_answer = new string[numRows, this.ReturnNumberofColumns(s, numRows)];
            int i = 0; //tracks word index
            int j = 0; //tracks row index
            int k = 0; //tracks column index

            while (i < s.Length)
            {
                j = 0;
                while (j < numRows && i < s.Length)
                {
                    array_answer[j, k] = s[i].ToString();
                    i++;
                    j++;
                }
                j-=2;
                k++;
                while (j > 0 && i < s.Length)
                {
                    array_answer[j, k] = s[i].ToString();
                    i++;
                    j--;
                    k++;
                }
            }

            for (int l = 0; l < array_answer.GetLength(0); l++)
            {
                for (int m = 0; m < array_answer.GetLength(1); m++)
                {
                    answer+= array_answer[l,m];
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
