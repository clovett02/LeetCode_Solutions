using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode_Solutions
{
    public static class DollarConverter
    {
        public static decimal? ConvertToDecimal(string word)
        {
            string RemoveDollarSign(string word)
            {
                int spot = word.IndexOf('$');
                if(spot < 0){return word;}
                else{return word.Remove(spot, 1);}
                
            }
            List<string> words = new List<string>();

            words = word.Split('.').ToList();
            if(words.Count > 2){return null;}
            
            words[0] = RemoveDollarSign(words[0]);
            words[1] = RemoveDollarSign(words[1]);

            decimal result = (decimal) System.Convert.ToDecimal(words[0] + "." + words[1]);
            return result;
        }
        
        public static List<decimal?> Convert(List<string> totals)
        {
            List<decimal?> result = new List<decimal?>();
            for (int i = 0; i < totals.Count; i++)
            {
                result.Add(ConvertToDecimal(totals[i]));
            }
            return result;
        }

    }
}
