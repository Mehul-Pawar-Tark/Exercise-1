using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions
{
    public class PalindromeDecoding
    {
        public String decode(String Code, int[] position, int[] lengths)  
        {
            for (int i = 0; i < position.Length; i++)
            {
                String Substring = Code.Substring(position[i], lengths[i]);
                String Revers_String = "";

                if (Substring.Length > 1)
                {
                    for (int j = Substring.Length - 1; j >= 0; j--)
                    {
                        Revers_String += Substring[j];
                    }
                }
                else
                    Revers_String = Substring;

                Code = Code.Substring(0, (position[i] + lengths[i])) + Revers_String + Code.Substring(position[i] + lengths[i]);        
            }

            return Code;
        }
    }
}
