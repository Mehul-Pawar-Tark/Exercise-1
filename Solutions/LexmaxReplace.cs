using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions
{
    public class LexmaxReplace
    {
        public String s = "";
        public String t = "";
        public void setInput()
        {
            s = "abb";
            t = "c";
        }
        public String get(String s,String t) 
        {
            String lexicographicalString = "";
            char[] S = s.ToCharArray();
            char[] T = t.ToCharArray();
            
            Array.Sort(T);
            int Index = T.Length-1;


            for(int i=0; i<S.Length; i++)
            {
                if (Index>=0 && T[Index] > S[i])
                    lexicographicalString+= T[Index--];
                else
                    lexicographicalString += S[i];
            }
            
            return lexicographicalString;
        }

    }
}
