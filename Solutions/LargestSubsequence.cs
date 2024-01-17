using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions
{
    public class LargestSubsequence
    {
        public String getLargest(String s) 
        { 
            String answer = "";
            int n = s.Length;

            int index = 0;

            while (index < n)
            {
                int max = index;
                int i = index + 1;

                while (i < n)
                {
                    if (s[i] > s[max])
                        max = i;

                    i++;
                }

                answer += s[max];
                index = max + 1;
            }

            return answer;
        }

    }
}
