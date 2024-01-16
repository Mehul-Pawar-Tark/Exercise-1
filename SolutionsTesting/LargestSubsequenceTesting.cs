using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Solutions;

namespace SolutionsTesting
{
    [TestClass]
    public class LargestSubsequenceTesting
    {
        [TestMethod]
        public void getLargest_VerifyString_ReturnsTrue() 
        {
            var largestSubsequence = new LargestSubsequence();

            String[] strs = {"test","a","example", "aquickbrownfoxjumpsoverthelazydog" };
            String[] answers = { "tt","a","xple","zyog"};

            bool isValid = true;

            for(int i = 0; i < strs.Length; i++)
            {
                if (!(largestSubsequence.getLargest(strs[i]).Equals(answers[i])))
                {
                    isValid = false; break;
                }
            }

            Assert.IsTrue(isValid); 
        }
    }
}
