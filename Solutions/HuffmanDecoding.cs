using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions
{
    public class HuffmanDecoding
    {
        public String Archive { get; set; }
        public Dictionary<string, string> Dictionary { get; set; }

        public void setinput()
        {
            Archive = "101101";

            Dictionary = new Dictionary<string, string>(){{"00", "A"},
                                                          {"10", "B"},
                                                          {"01", "C"},
                                                          {"11", "D" } };
        }
        

        #region 1. Huffman
        public String decode(String Archive, Dictionary<string, string> Dictionary)   //Convert encoded String in Original Text 
        {
            
            String OriginalText = "";

            int index = 0;
            int n = Archive.Length;

            while (index < n)
            {
                string key = "";

                while (index < n)
                {
                    key += Archive[index++];

                    if (Dictionary.ContainsKey(key))
                    {
                        OriginalText += Dictionary[key];
                        break;
                    }
                }
            }

            return OriginalText;
        }
        #endregion
    }
}
