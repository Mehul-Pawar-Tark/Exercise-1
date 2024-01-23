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

            List<String[]> ListsA = getListsA();
            List<String[]> ListsB = getListsB();
            List<String[]> ListsC = getListsC();
            String[] answers =getAnswers();

            bool IsValid = true;

            for (int i = 0; i < answers.Length; i++)
            {
                if (!(wordCompositionGame.score(ListsA[i], ListsB[i], ListsC[i]).Equals(answers[i])))
                {
                    IsValid = false; break;
                }
            }
            Assert.IsTrue(IsValid);
        }

        public String[] getAnswers()
        {
            return new String[] { "8/3/3", "3/5/5", "4/4/4", "14/14/21" };
        }

        public List<String[]> getListsA()
        {
            List<String[]> ListsA = new List<String[]>();
            ListsA.Add(new String[] { "cat", "dog", "pig", "mouse" });
            ListsA.Add(new String[] { "mouse" });
            ListsA.Add(new String[] { "dog", "mouse" });
            ListsA.Add(new String[] { "bcdbb", "aaccd", "dacbc", "bcbda", "cdedc", "bbaaa", "aecae" });

            return ListsA;
        }
        public List<String[]> getListsB()
        {
            List<String[]> ListsB = new List<String[]>();
            ListsB.Add(new String[] { "cat", "pig" });
            ListsB.Add(new String[] { "cat", "pig" });
            ListsB.Add(new String[] { "dog", "pig" });
            ListsB.Add(new String[] { "bcdbb", "ddacb", "aaccd", "adcab", "edbee", "aecae", "bcbda" });

            return ListsB;
        }

        public List<String[]> getListsC()
        {
            List<String[]> ListsC = new List<String[]>();
            ListsC.Add(new String[] { "dog", "cat" });
            ListsC.Add(new String[] { "dog", "cat" });
            ListsC.Add(new String[] { "dog", "cat" });
            ListsC.Add(new String[] { "dcaab", "aadbe", "bbaaa", "ebeec", "eaecb", "bcbba", "aecae", "adcab", "bcbda" });

            return ListsC;
        }
    }
}
