using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Solutions;

namespace SolutionsTesting
{
    [TestClass]
    public class MovingAvgTesting
    {
        [TestMethod]
        public void difference_Comparedifference_ReturnsTrue() 
        {
            var movingAvg = new MovingAvg();

            int[] N = getN();
            List<Double[]> numbers = new List<Double[]>();
            numbers.Add(new Double[] { 3, 8, 9, 15 });
            numbers.Add(new Double[] { 17, 6.2, 19, 3.4 });
            numbers.Add(new Double[] { 6, 2.5, 3.5 });

            Double[] answers = getAnswers();

            bool Isvalide = true;

            for (int i = 0; i < N.Length; i++)
            {
                if (!(movingAvg.difference(N[i], numbers[i]).Equals(answers[i])))
                {
                    Isvalide = false;
                    break;
                }
            }

            Assert.IsTrue(Isvalide);
        }
        public double[] getAnswers() 
        {
            return new double[] { 6.5, 4.533333333333335, 0.0 };
        }
        public int[] getN()
        {
            return new int[] { 2, 3, 3 };
        }

        public List<Double[]> getNumbers()
        {
            List<Double[]> numbers = new List<Double[]>();
            numbers.Add(new Double[] { 3, 8, 9, 15 });
            numbers.Add(new Double[] { 17, 6.2, 19, 3.4 });
            numbers.Add(new Double[] { 6, 2.5, 3.5 });

            return numbers;
        }


    }

}
