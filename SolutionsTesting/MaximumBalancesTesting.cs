using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Solutions;

namespace SolutionsTesting
{
    [TestClass]
    public class MaximumBalancesTesting
    {
        [TestMethod]
        public void solve_CheckMaxBalance_ReturnsTrue() 
        {
            var maximumBalances = new MaximumBalances();

            String[] strs = getStsrs();
            int[] answers = getanswers();

            bool IsValid = true;

            for(int i = 0; i < strs.Length; i++) 
            {
                if (!(maximumBalances.solve(strs[i]).Equals(answers[i])))
                {
                    IsValid = false; break;
                }
            }

            Assert.IsTrue(IsValid); 
        }
        public int[] getanswers()
        {
            return new int[] { 0, 3, 1, 10 };

        }

        public String[] getStsrs()
        {
            return new String[]  { "((((", "(())", ")))())", "))()()))(()" };
        }

    }
}
