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

            List<int[]> Numbers = getNumbers();

            int[] answer = getAnswers();

            for (int i = 0; i < Numbers.Count; i++)
            {
                if (!(sortingSubsets.getMinimalSize(Numbers[i]).Equals(answer[i])))
                {
                    isvalide = false; break;
                }
            }

            Assert.IsTrue(isvalide);

        }

        public int[] getAnswers()
        {
            return new int[] { 2, 0, 6, 7 };
        }
        public List<int[]> getNumbers()
        {
            List<int[]> Numbers = new List<int[]>();
            Numbers.Add(new int[] { 3, 2, 1 });
            Numbers.Add(new int[] { 1, 2, 3, 4 });
            Numbers.Add(new int[] { 4, 4, 4, 3, 3, 3 });
            Numbers.Add(new int[] { 11, 11, 49, 7, 11, 11, 7, 7, 11, 49, 11 });

            return Numbers;
        }
    }
}
