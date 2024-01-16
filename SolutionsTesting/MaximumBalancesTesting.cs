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
        public void MaximumBalances() 
        {
            var maximumBalances = new MaximumBalances();

            String[] strs = { };
            String[] answers = { };

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
    }
}
