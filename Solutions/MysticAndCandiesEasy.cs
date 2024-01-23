using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions
{
    public class MysticAndCandiesEasy
    {
        public int minBoxes(int C,int X, int[] high)
        {
            Array.Sort(high);
            int Length=high.Length;

            int index = 0;

            while(index<Length)
            {
                C -= high [ index ];

                if(C<X)
                    return ( Length - index );
                
                index++;
            }

            return 0;
        }

        
    }
}
