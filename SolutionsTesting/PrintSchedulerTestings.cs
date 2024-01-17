using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Solutions;

namespace SolutionsTesting
{
    [TestClass]
    public class PrintSchedulerTestings
    {
        [TestMethod]
        public void getOutput_verifyOutput_ReturnsTrue()
        {
            var printScheduler = new PrintScheduler();

            List<String[]> Threads = getThreads();
            List<String[]> Slices = getSlices();
            String[] answers = getAnswers();

            bool IsValid = true;

            for (int i = 0; i < answers.Length; i++)
            {
                if (!(printScheduler.getOutput(Threads[i], Slices[i]).Equals(answers[i])))
                {
                    IsValid = false; break;
                }
            }
            Assert.IsTrue(IsValid);
        }

        public String[] getAnswers() 
        {
            return new String[] { "ACBDC", "ABCDEABCDEABCDEABCDEABCDEABCDEABCDEABCDEA", "BBBBBBBBBBABBBBBBBBBBAA", "A" };
        }

        public List<String[]> getSlices() 
        {
            List<String[]> Slices = new List<String[]>();
            Slices.Add(new String[] { "0 1", "1 1", "0 1", "1 2" });
            Slices.Add(new String[] { "0 20", "0 21" });
            Slices.Add(new String[] { "1 10", "0 1", "1 10", "0 2" });
            Slices.Add(new String[] { "0 1" });

            return Slices;
        }

        public List<String[]> getThreads()
        {
            List<String[]> Threads = new List<String[]>();
            Threads.Add(new String[] { "AB", "CD" });
            Threads.Add(new String[] { "ABCDE" });
            Threads.Add(new String[] { "A", "B" });
            Threads.Add(new String[] { "A" });

            return Threads;
        }

    }
}
