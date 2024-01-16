using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Solutions;

namespace SolutionsTesting
{
    [TestClass]
    public class SortingSubsetsTesting
    {
        [TestMethod]
        public void getMinimalSize_VerifySize_Returnstrue()
        {
            var sortingSubsets = new SortingSubsets();

            bool isvalide = true;

            List<int[]> numbers=new List<int[]>();
            int[] val1 = { 3, 2, 1 }; numbers.Add(val1);
            int[] val2 = { 1, 2, 3, 4 }; numbers.Add(val2);
            int[] val3 = { 4, 4, 4, 3, 3, 3 }; numbers.Add(val3);
            int[] val4 = { 11, 11, 49, 7, 11, 11, 7, 7, 11, 49, 11 }; numbers.Add(val4);
            
            int[] answer = {2,0,6,7 };

            
            for(int i = 0; i < numbers.Count; i++)
            {
                if (!(sortingSubsets.getMinimalSize(numbers[i]).Equals(answer[i])))
                {
                    isvalide = false;break;
                }
            }


            Assert.IsTrue(isvalide);

        }
    }
}
