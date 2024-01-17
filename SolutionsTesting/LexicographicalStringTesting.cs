using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Solutions;

namespace SolutionsTesting
{
    [TestClass]
    public class LexicographicalStringTesting
    {
        [TestMethod]
        public void get_LexicographicalString_Returnstrue()
        {
            var lexmaxReplace = new LexmaxReplace();

            String[] S =GetS();
            String[] T = GetT();

            String[] Answer = GetAnswers();

            bool isvalid = true;
            
            for(int i=0; i<5; i++) 
            {
                if (!(lexmaxReplace.get(S[i], T[i]).Equals(Answer[i])))
                {
                    isvalid = false; break;
                }
            }
            
            Assert.IsTrue(isvalid);
        }

        public String[] GetAnswers()
        {
            return new String[] { "cbb", "z", "feeeba", "trp", "zyyyzyxwwwzwvuuttxwtssvtssxrqxppqrontmmllukrkjvwlr" };
        }
        public String[] GetS()
        {
            return new String[] { "abb", "z", "fedcba", "top", "xldyzmsrrwzwaofkcxwehgvtrsximxgdqrhjthkgfucrjdvwlr" };
        }
        public String[] GetT()
        {
            return new String[] { "c", "f", "ee", "coder", "xfpidmmilhdfzypbguentqcojivertdhshstkcysydgcwuwhlk" };
        }
    }
}
