using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions
{
    public class MaximumBalances
    {
        public int solve(String s)
        {
            int Beauty = 0;

            int Start_Parentheses = 0;
            int End_Parentheses = 0;
            int Pair_Of_Parentheses= 0;

            for(int i=0; i<s.Length; i++)
            {
                if (s[i] == '(')
                    Start_Parentheses++;
                
                if (s[i]==')')
                    End_Parentheses++;
                    
            }

            Pair_Of_Parentheses = Start_Parentheses < End_Parentheses ? Start_Parentheses : End_Parentheses;

            Beauty=(Pair_Of_Parentheses*(Pair_Of_Parentheses+1))/2;

            return Beauty;
        }
    }
}
