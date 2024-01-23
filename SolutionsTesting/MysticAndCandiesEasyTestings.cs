﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Solutions;

namespace SolutionsTesting
{
    [TestClass]
    public class MysticAndCandiesEasyTestings
    {
        [TestMethod]
        public void minboxes_CompareBoxes_ReturnsTrue()
        {
            var mysticAndCandiesEasy = new MysticAndCandiesEasy();

            int[] C = getC();
            int[] X = getX();

            List<int[]> Highs = getHights();

            int[] answers =getAnswers();

            bool IsValid = true;

            for (int i = 0; i < answers.Length; i++)
            {
                if (!(mysticAndCandiesEasy.minBoxes(C[i], X[i], Highs[i]).Equals(answers[i])))
                {
                    IsValid = false; break;
                }
            }

            Assert.IsTrue(IsValid);
        }

        public int[] getAnswers() 
        {
            return new int[] { 1, 4, 3, 22, 15 };
        }
        public int[] getC()
        {
            return new int[] { 10, 10, 100, 19, 326 };

        }
        public List<int[]> getHights() 
        {
            List<int[]> Highs = new List<int[]>();
            Highs.Add(new int[] { 20 });
            Highs.Add(new int[] { 3, 3, 3, 3, 3 });
            Highs.Add(new int[] { 12, 34, 23, 45, 34 });
            Highs.Add(new int[] { 12, 9, 15, 1, 6, 4, 9, 10, 10, 10, 14, 14, 1, 1, 12, 10, 9, 2, 3, 6, 1, 7, 3, 4, 10, 3, 14 });
            Highs.Add(new int[] { 9, 13, 6, 6, 6, 16, 16, 16, 10, 16, 4, 3, 10, 8, 11, 17, 12, 5, 7, 8, 7, 4, 15, 7, 14, 2, 2, 1, 17, 1, 7, 7, 12, 17, 2, 9, 7, 1, 8, 16, 7, 4, 16, 2, 13, 3, 13, 1, 17, 6 });

            return Highs;
        }
        public int[] getX()
        {
            return new int[] { 10, 7, 63, 12, 109 }; 
        }
    }
}
