using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions
{
    public class Mailbox
    {
        public int impossible(String collection, String[] addresses)
        {
            int impossible_address = 0;

            Dictionary<char, int> Collection_dictionary = new Dictionary<char, int>();

            int collection_length=collection.Length;
            
            for(int index = 0; index<collection_length; index++)
            {
                if (Collection_dictionary.ContainsKey(collection[index]))
                    Collection_dictionary[collection[index]]++;
              
                else
                    Collection_dictionary.Add(collection[index],1);
            }
            
            foreach (string address in addresses)
            {
                Dictionary<char, int> Address_dictionary = new Dictionary<char, int>();

                int Address_length = address.Length;

                for (int index = 0; index < Address_length; index++)
                {
                    if (address[index] == ' ') continue;

                    if (Address_dictionary.ContainsKey(address[index]))
                        Address_dictionary[address[index]]++;

                    else
                        Address_dictionary.Add(address[index], 1);
                }

                foreach(KeyValuePair<char, int> kvp in Address_dictionary)
                {
                    int value = Address_dictionary[kvp.Key];

                    if (!Collection_dictionary.ContainsKey(kvp.Key) || value > Collection_dictionary[kvp.Key])
                    {
                        impossible_address++;
                        break;
                    }
                }
            }

            return impossible_address;
        }

    }
}
