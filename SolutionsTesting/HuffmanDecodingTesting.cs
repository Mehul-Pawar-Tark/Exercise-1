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

            String[] arr = { "101101", "10111010", "0001001100100111001" };
            Dictionary<String, String> dict1 = new Dictionary<string, string>(){{"00", "A"},
                                                          {"10", "B"},
                                                          {"01", "C"},
                                                          {"11", "D" } };
            Dictionary<String, String> dict2 = new Dictionary<string, string>(){{"0", "A"},
                                                          {"111", "B"},
                                                          {"10", "C"} };

            Dictionary<String, String> dict3 = new Dictionary<string, string>(){{"1", "A"},
                                                          {"0", "B"} };
            Dictionary<String, String>[] dictionaris = { dict1, dict2, dict3 };

            String[] answer = { "BDC", "CBAC", "BBBABBAABBABBAAABBA" };

            bool isValid = true;

            isValid = huffmanDecoding.decode(arr[2], dictionaris[2]).Equals(answer[2]);


            for (int i = 0; i < 3; i++)
            {
                if (!(huffmanDecoding.decode(arr[i], dictionaris[i]) == answer[i]))
                {
                    isValid = false;

                    break;
                }
            }

            Assert.IsTrue(isValid);
        }
    }
}