using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode_Solutions
{
    /// <summary>
    /// Class for solving fibonacci sequence
    /// </summary>
    public class fib
    {
        public static int solution(int n)
        {
            if (n <= 2)
            {
                return 1;
            }
            else
            {
                int a = solution(n - 1);
                int b = solution(n - 2);
                return a + b;
            }
        }
    }
}
