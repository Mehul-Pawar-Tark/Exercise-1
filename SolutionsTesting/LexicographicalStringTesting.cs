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

            String[] S ={"abb","z","fedcba","top", "xldyzmsrrwzwaofkcxwehgvtrsximxgdqrhjthkgfucrjdvwlr" };
            String[] T = {"c","f","ee","coder", "xfpidmmilhdfzypbguentqcojivertdhshstkcysydgcwuwhlk" };

            String[] Answer = { "cbb","z","feeeba","trp", "zyyyzyxwwwzwvuuttxwtssvtssxrqxppqrontmmllukrkjvwlr"};

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
    }
}
