using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions
{
    public class SortingSubsets
    {
        public int[] nums = new int[11];
        public void setInput()
        {

            nums = [ 11, 11, 49, 7, 11, 11, 7, 7, 11, 49, 11 ];

        }
        public int getMinimalSize(int[] nums)   
        {
            int change = 0;
            int length= nums.Length;


            int[] arr = new int[length];

            for (int i = 0; i < length; i++)
            {
                arr[i] = nums[i];
            }
            Array.Sort(arr);

            for (int i = 0; i <length; i++)
            {
                if (arr[i] != nums[i])
                    change++;
            }



            return change;
        }
    }
}
