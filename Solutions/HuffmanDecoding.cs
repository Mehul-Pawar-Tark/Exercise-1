using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions
{
    public class HuffmanDecoding
    {
        
        public String decode(String archive, String[] dictionary)   
        {
           
            String OriginalText = "";

            Dictionary<string,char> Dictionary = new Dictionary<string,char>();

            char Value = 'A';
            foreach(String Key in dictionary) 
                Dictionary.Add(Key, Value++);

            int index = 0;
            int n = archive.Length;

                string key = "";

                while (index < n)
                {
                    key += archive[index++];

                    if (Dictionary.ContainsKey(key))
                    {
                        OriginalText += Dictionary[key];
                        key = "";
                     
                    }
                }

            return OriginalText;
        }
    }
}
