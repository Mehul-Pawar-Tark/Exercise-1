using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions
{
    public class HuffmanDecoding
    {
        public String decode(String archive, String[] dictionary)   //Convert encoded String in Original Text 
        {
           
            String OriginalText = "";

            int index = 0;
            int n = archive.Length;

            while (index < n)
            {
                string key = "";

                while (index < n)
                {
                    key += archive[index++];

                    if (dictionary.Contains(key))
                    {
                        OriginalText += (char) ( ((int)('A')) + (Array.IndexOf(dictionary,key) ) );
                        break;
                    }
                }
            }

            return OriginalText;
        }
    }
}
