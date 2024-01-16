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
            var movingAvg=new MovingAvg();

            int[] N = { 2,3,3};
            List<Double[]> numbers = new List<Double[]>();
            Double[] val1 = { 3, 8, 9, 15 }; numbers.Add(val1);
            Double[] val2 = { 17, 6.2, 19, 3.4 }; numbers.Add(val2);
            Double[] val3 = { 6, 2.5, 3.5 }; numbers.Add(val3);

            Double[] answers = {6.5, 4.533333333333335,0.0};

            bool Isvalide = true;

            for(int i = 0; i < N.Length; i++) 
            {
                if (!(movingAvg.difference(N[i], numbers[i]).Equals(answers[i])))
                {
                        Isvalide = false; 
                    break;
                }
            }

            Assert.IsTrue(Isvalide);
        }
    }
}
