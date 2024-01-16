using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Solutions;

namespace SolutionsTesting
{
    [TestClass]
    public class WordCompositionGametesting
    {
        [TestMethod]
        public void score_CompareScore_Returnstrue()
        {
            var wordCompositionGame = new WordCompositionGame();

            List<String[]> lists1 = new List<String[]>();
            String[] list11 = { "cat", "dog", "pig", "mouse" }; lists1.Add(list11);
            String[] list12 = { "mouse" }; lists1.Add(list12);
            String[] list13 = { "dog", "mouse" }; lists1.Add(list13);
            String[] list14 = { "bcdbb", "aaccd", "dacbc", "bcbda", "cdedc", "bbaaa", "aecae" }; lists1.Add(list14);

            List<String[]> lists2 = new List<String[]>();
            String[] l21 = { "cat", "pig" }; lists2.Add(l21);
            String[] l22 = { "cat", "pig" }; lists2.Add(l22);
            String[] l23 = { "dog", "pig"}; lists2.Add(l23);
            String[] l24 = { "bcdbb", "ddacb", "aaccd", "adcab", "edbee", "aecae", "bcbda" }; lists2.Add(l24);

            List<String[]> lists3 = new List<String[]>();
            String[] l31 = { "dog", "cat" }; lists3.Add(l31);
            String[] l32 = { "dog", "cat" }; lists3.Add(l32);
            String[] l33 = { "dog", "cat" }; lists3.Add(l33);
            String[] l34 = {"dcaab","aadbe","bbaaa","ebeec","eaecb","bcbba","aecae","adcab","bcbda"}; lists3.Add(l34); 

            String[] answers = { "8/3/3","3/5/5","4/4/4","14/14/21" };

            bool IsValid = true;

            for(int i=0; i<answers.Length; i++)
            {
                if (!(wordCompositionGame.score(lists1[i], lists2[i], lists3[i]).Equals(answers[i])))
                {
                    IsValid = false; break;
                }
            }


            Assert.IsTrue(IsValid);
        }
    }
}
