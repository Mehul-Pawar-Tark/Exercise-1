using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions
{
    public class MysticAndCandiesEasy
    {
        public int C=10;
        public int X=7;
        public int[] high = { 3,3,3,3};
        
        public int minBoxes(int C,int X, int[] high)
        {
           
            Array.Sort(high);
            int len=high.Length;

            int index = 0;

            while(index<len)
            {
                C -= high[index];

                if(C<X)
                    return (len-index);
                
                index++;
            }

            return 0;
        }

        
    }
}
