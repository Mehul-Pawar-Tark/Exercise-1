using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions
{
    public class LexmaxReplace
    {
        public String get(String s,String t) 
        {
            String lexicographicalString = "";

            char[] array_of_s = s.ToCharArray();
            char[] arrays_of_t = t.ToCharArray();
            
            Array.Sort(arrays_of_t);
            int Index = arrays_of_t.Length-1;


            for(int i=0; i<array_of_s.Length; i++)
            {
                lexicographicalString += (Index >= 0 && arrays_of_t[Index] > array_of_s[i]) ? arrays_of_t[Index--] : array_of_s[i];
            }
            
            return lexicographicalString;
        }

    }
}
