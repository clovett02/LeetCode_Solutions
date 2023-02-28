

namespace LeetCode_Solutions
{
    ///<summary>
    /// Class for converting Roman Numeral characters
    /// into decimal numbers.
    /// </summary>
    public class RomantoInteger
    {
        public static int solution(string letters)
        {
            int answer = 0;
            int[] numbers = new int[letters.Length];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = ReturnNumberforChar(letters[i]);
            }
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] < numbers[i + 1])
                {
                    numbers[i] = 0 - numbers[i];
                }
                answer += numbers[i];
            }

            return answer;
        }
        private static int ReturnNumberforChar(char c)
        {
            int answer = 0;
            switch (c)
            {
                case 'I': answer = 1; break;
                case 'V': answer = 5; break;
                case 'X': answer = 10; break;
                case 'L': answer = 50; break;
                case 'C': answer = 100; break;                    
                case 'D': answer = 500; break;    
                case 'M': answer = 1000; break;    

                default: answer = 0; break;

            }
            return answer;
        }
    }
}