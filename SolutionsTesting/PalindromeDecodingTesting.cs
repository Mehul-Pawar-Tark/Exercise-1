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

            String[] strs = { "ab", "Misip", "XY", "TC206", "nodecoding" };
            List<int[]> positions=new List<int[]>();
            int[] pos1 = {0 }; positions.Add(pos1);
            int[] pos2 = { 2, 3, 1, 7 }; positions.Add(pos2);
            int[] pos3= { 0, 0, 0, 0 }; positions.Add(pos3);
            int[] pos4= { 1, 2, 5 }; positions.Add(pos4);
            int[] pos5 = { }; positions.Add(pos5);

            List<int[]> lengths = new List<int[]>();
            int[] len1 = {2 }; lengths.Add(len1);
            int[] len2 = { 1, 1, 2, 2 }; lengths.Add(len2);
            int[] len3 = { 2, 4, 8, 16 }; lengths.Add(len3);
            int[] len4 = { 1, 1, 1 }; lengths.Add(len4);
            int[] len5 = { }; lengths.Add(len5);

            String[] answers = { "abba" , "Mississippi", "XYYXXYYXXYYXXYYXXYYXXYYXXYYXXYYX","TCCC2006", "nodecoding" };
   
            for (int i=0; i<strs.Length-4; i++)
            {
                if (!(palindromeDecoding.decode(strs[i], positions[i], lengths[i]).Equals(answers[i])))
                {
                    IsValid = false; break;
                }
            }
            

            Assert.IsTrue(IsValid);


        }
    }
}
