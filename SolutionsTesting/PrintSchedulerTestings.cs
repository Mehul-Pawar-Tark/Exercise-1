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

            List<String[]> Threads = new List<String[]>();
            String[] thread1 = { "AB", "CD" }; Threads.Add(thread1);
            String[] thread2 = { "ABCDE" }; Threads.Add(thread2);
            String[] thread3 = { "A", "B" }; Threads.Add(thread3);
            String[] thread4 = { "A"};  Threads.Add(thread4);


            List<String[]> Slices = new List<String[]>();
            String[] Slice1 = { "0 1", "1 1", "0 1", "1 2" }; Slices.Add(Slice1);
            String[] Slice2 = { "0 20", "0 21" };   Slices.Add(Slice2);
            String[] Slice3 = { "1 10", "0 1", "1 10", "0 2" }; Slices.Add(Slice3);
            String[] Slice4 = { "0 1" }; Slices.Add(Slice4);

            String[] answers = {"ACBDC","ABCDEABCDEABCDEABCDEABCDEABCDEABCDEABCDEA", "BBBBBBBBBBABBBBBBBBBBAA", "A" };

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
    }
}
