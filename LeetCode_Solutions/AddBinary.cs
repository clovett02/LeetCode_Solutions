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
            int carry = 0;

            for (int i = 0; i < longernum.Length; i++)
            {
                if(i < shorternum.Length)
                {
                    if(longernum[i] == '1' && shorternum[i] == '1') 
                    {
                        if(carry == 1) { result += '1'; carry = 1; }
                        else { result += '0'; carry = 1; }
                    }
                    
                    else if (longernum[i] == '1' || shorternum[i] == '1') 
                    {
                        if(carry == 1)
                        {
                            result += '0';
                            carry = 1;
                        }
                        else
                        {
                            result += '1';
                            carry = 0;
                        }
                    }

                    else { result += Convert.ToString(carry); carry = 0; }
                }
                else 
                {
                    if(carry == 1 && longernum[i] == '1')
                    {
                        result += "0"; carry = 1;
                    }
                    else { result += longernum[i]; carry = 0; }

                }
            }
            if(carry == 1) { result += '1'; }

            return result;
        }
        public string Solution(string num1, string num2)
        {
            string result = "";
            string num1reversed = ReverseString(num1);
            string num2reversed = ReverseString(num2);
            if (num1.Length > num2.Length)
            {
                result = ReverseString(AddReversedBinaryStrings(longernum: num1reversed, shorternum: num2reversed));
            }
            else
            {
                result = ReverseString(AddReversedBinaryStrings(longernum:num2reversed, shorternum: num1reversed));
            }

            return result;
        }
    }
}