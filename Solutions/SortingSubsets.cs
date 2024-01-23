using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions
{
    public class SortingSubsets
    {   
      
        public int getMinimalSize(int[] a)   
        {
            int change = 0;
            int length= a.Length;

            int[] Duplicate=new int[length];

            a.CopyTo(Duplicate, 0 );
            Array.Sort(Duplicate);

            for (int i = 0; i <length; i++)
            {
                if (Duplicate[i] != a[i])
                    change++;
            }

            return change;
        }
    }
}
