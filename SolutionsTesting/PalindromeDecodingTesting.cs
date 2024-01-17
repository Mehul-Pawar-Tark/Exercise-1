using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Solutions;

namespace SolutionsTesting
{
    [TestClass]
    public class PalindromeDecodingTesting
    {
        [TestMethod]
        public void Decode_PalindromeDecoding_ReturnsTrue() 
        {
            var palindromeDecoding = new PalindromeDecoding();

            bool IsValid = true;

            String[] strs = getStrs();
            List<int[]> Positions = getPositions();
            List<int[]> Lengths = getLengths();
            String[] answers = getAnswers();

            for (int i = 0; i < strs.Length - 4; i++)
            {
                if (!(palindromeDecoding.decode(strs[i], Positions[i], Lengths[i]).Equals(answers[i])))
                {
                    IsValid = false; break;
                }
            }

            Assert.IsTrue(IsValid);

        }

        public String[] getAnswers()
        {
            return new string[] { "abba", "Mississippi", "XYYXXYYXXYYXXYYXXYYXXYYXXYYXXYYX", "TCCC2006", "nodecoding" };
        }


        public List<int[]> getLengths()
        {
            List<int[]> Lengths = new List<int[]>();
            Lengths.Add(new int[] { 2 });
            Lengths.Add(new int[] { 1, 1, 2, 2 });
            Lengths.Add(new int[] { 2, 4, 8, 16 });
            Lengths.Add(new int[] { 1, 1, 1 });
            Lengths.Add(new int[] { });

            return Lengths;

        }
        public List<int[]> getPositions()
        {
            List<int[]> Positions = new List<int[]>();
            Positions.Add(new int[] { 0 });
            Positions.Add(new int[] { 2, 3, 1, 7 });
            Positions.Add(new int[] { 0, 0, 0, 0 });
            Positions.Add(new int[] { 1, 2, 5 });
            Positions.Add(new int[] { });

            return Positions;

        }

        public String[] getStrs()
        {
            return new string[] { "ab", "Misip", "XY", "TC206", "nodecoding" };
        }
    }
}
