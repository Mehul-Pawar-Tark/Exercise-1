using Solutions;

namespace SolutionsTesting
{
    [TestClass]
    public class HuffmanDecodingTesting
    {
        [TestMethod]
        public void decode_VerifyDecodedstring_Returnstrue()
        {
            var huffmanDecoding = new HuffmanDecoding();

            String[] strings = getStrings();

            List<String[]> dictionaris = getDectionaris();

            String[] answer = getAnswers();

            bool isValid = true;

            for (int i = 0; i < answer.Length; i++)
            {
                if (!(huffmanDecoding.decode(strings[i], dictionaris[i]) == answer[i]))
                {
                    isValid = false; break;
                }
            }

            Assert.IsTrue(isValid);
        }
        public String[] getAnswers()
        {
            return new String[] { "BDC", "CBAC", "BBBABBAABBABBAAABBA" };
        }
        public List<String[]> getDectionaris() 
        {
            List<String[]> dictionaris=new List<String[]>();
            dictionaris.Add(new String[] { "00", "10", "01", "11" });
            dictionaris.Add(new String[] { "0", "111", "10" });
            dictionaris.Add(new String[] { "1", "0" });
            dictionaris.Add(new String[] { "010", "00", "0110", "0111", "11", "100", "101" });

            return dictionaris;
            
        }
        public String[] getStrings()
        {
            return new  String[] { "101101", "10111010", "0001001100100111001" };
        }

    }
}